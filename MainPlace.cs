using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ControlWork.Data;
using Excel = Microsoft.Office.Interop.Excel;
using GMap;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleMaps.LocationServices;
using System.Windows.Forms.DataVisualization.Charting;
using GMap.NET.MapProviders;
using System.Text.RegularExpressions;

namespace ControlWork
{
    public partial class MainPlace : Form
    {
        public MainPlace()
        {
            Database.SetInitializer<DemoContext>(new CreateDatabaseIfNotExists<DemoContext>());
            InitializeComponent();
            daysWorkedMonthCalendar1.ShowWeekNumbers = true;
            showDataGridView();
        }
        public List<int> indexColoursRows = new List<int>(); //out because it uses in two methods to paint colours
        public void showDataGridView() //show datagridview and days worked on calendar
        {
            textStepsBox.Visible = false;
            var dbContext = new DemoContext();
            //System.Collections.ObjectModel.ObservableCollection<DataReg> valuesBd = new System.Collections.ObjectModel.ObservableCollection<DataReg>();
            List<DataReg> valuesBd = new List<DataReg>();
            List<string> zipCodes = new List<string>();
            List<string> infoSites = new List<string>();
            List<int> infoNumerOfWeek = new List<int>();
            List<decimal> earnedWeek = new List<decimal>();

            var listBd = from p in dbContext.DataWorks select p;
            long countRegs = listBd.LongCount() -1; //to calculate earned per week
            decimal totalEarned = 0;
            decimal totalEarnedWeek = 0;
            decimal totalEarnedWeekTemp = 0;
            decimal earnedAfterSchools = 0;
            decimal earnedBreakfastSchools = 0;
            decimal earnerCreche = 0;
            decimal earnedNursery = 0;
            int wn = 0; //week number
            int j = 0;
            int ws = 8; //start work at this week, week start
            listBox1.Items.Clear(); 
            foreach (var p in listBd)
            {
                valuesBd.Add(new DataReg() { Id = p.Id, typeWork = p.typeWork, siteWork = p.siteWork, zipCode = p.zipCode, detailsWork = p.detailsWork, dateWork = p.dateWork, timeStartWork = p.timeStartWork, timeFinishWork = p.timeFinishWork, timeWorked = p.timeWorked, earned = p.earned, paid = p.paid });
                DateTime DayWorked = DateTime.Parse(p.dateWork.ToString());
                daysWorkedMonthCalendar1.AddBoldedDate(DayWorked);
                totalEarned = p.earned + totalEarned;
                switch (p.typeWork)
                {
                    case "After School":
                        earnedAfterSchools = earnedAfterSchools + p.earned;
                        break;
                    case "Creche":
                        earnerCreche = earnerCreche + p.earned;
                        break;
                    case "Breakfast Club":
                        earnedBreakfastSchools = earnedBreakfastSchools + p.earned;
                        break;
                    case "Nursery":
                        earnedNursery = earnedNursery + p.earned;
                        break;
                }
                zipCodes.Add(p.zipCode); //later info for add Marks on map
                infoSites.Add(p.siteWork); //later info for add Marks on map
                wn = GetWeekNumber(DayWorked);
                indexColoursRows.Add(wn); //to paint weeks in datagrid
                if ((ws == wn) && !(j == countRegs))   //this if it´s for show earnedWeek, store in earnedWeek list the earend per week
                {
                    totalEarnedWeek = p.earned + totalEarnedWeek;
                }
                else
                {
                    if (j == countRegs)
                    {
                        totalEarnedWeek = p.earned + totalEarnedWeek;
                        wn++;
                    }
                    earnedWeek.Add(totalEarnedWeek + totalEarnedWeekTemp);
                    infoNumerOfWeek.Add(wn-1);
                    listBox1.MultiColumn = true;
                    //listBox1.Items.AddRange(new object[] {  "Week: " +(wn - 1) , "£"+(totalEarnedWeek + totalEarnedWeekTemp) });
                    listBox1.Items.Add("Week " + (wn - 1) + ": £" + (totalEarnedWeek + totalEarnedWeekTemp));
                    totalEarnedWeekTemp = p.earned; //for the last day of the week
                    totalEarnedWeek = 0;
                    ws = wn;
                }
                j++;
            }
            totalEarnedLabel1.Text = "Total Earned: £" + totalEarned;
            earnedAfterSchoolLabel.Text = "Earned After School Clubs: £" + earnedAfterSchools;
            earnedBreakfastLabel.Text = "Earned Breakfast Clubs: £" + earnedBreakfastSchools;
            earnedCrecheLabel.Text = "Earned Creche: £" + earnerCreche;
            earnedNurseryLabel.Text = "Earned Nursery: £" + earnedNursery;
            earnedDaySelectedLabel.Text = "";
            dataGridView1.DataSource = valuesBd;
            dataGridView1.Columns[0].Visible = false;
            List<string> zipCodes2 = zipCodes.Distinct().ToList();   //delete repets
            List<string> infoSites2 = infoSites.Distinct().ToList();
            showGraphics(earnedWeek, infoNumerOfWeek);
            showMap(zipCodes2, infoSites2);
        }
        void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //f you try and set the cell colour within the constructor of the form you will be hitting before the data binding is completed so the changes to the cells don't stick. The most straightforward fix to this is to set the colours a little later - usually within a DataBindingComplete event handler
        {
            dataGridView1.AutoResizeColumns( DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            int i = 0;
            int j = 0;
            for (j = 0; j < dataGridView1.RowCount; j++)
            {
                if ((indexColoursRows[j] % 2) != 0)
                {
                    dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                i++;
            }

        }
        int GetWeekNumber(DateTime dtPassed)
        {
            System.Globalization.CultureInfo ciCurr = System.Globalization.CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
        void showMap(List<string> zipCodes2, List<string> infoSites2) //add lib Gmap, and add Gmapcontrol in toolbox, in Choose toolbox items 
        { //improve: add if when there is no Internet
            disLabel.Text = "";
            gmap.Overlays.Clear();
            var address = "EH3 9JX"; // home location
            var locationService = new GoogleLocationService(); //Install-Package GoogleMaps.LocationServices ,for get position
            var point= locationService.GetLatLongFromAddress(address);
            if (point != null)
            {
                var latitude = point.Latitude;
                var longitude = point.Longitude;
                //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly; // se cached information (if available) to show your maps
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.SetPositionByKeywords("EH3 9JX"); // home location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.green); // My home
                marker.ToolTipText = "My Home";
                markersOverlay.Markers.Add(marker);
                int i = 0;
                for (i = 0; i < zipCodes2.LongCount(); i++)
                {
                    address = zipCodes2[i];
                    //locationService = new GoogleLocationService(); //Install-Package GoogleMaps.LocationServices ,for get position
                    point = locationService.GetLatLongFromAddress(address);
                    if (point != null)
                    {
                        latitude = point.Latitude;
                        longitude = point.Longitude;
                        marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.red);
                        marker.ToolTipText = infoSites2[i];
                        markersOverlay.Markers.Add(marker);
                    }
                }
                gmap.Overlays.Add(markersOverlay);
                gmap.Zoom = 11;
                gmap.Refresh();
            }
        }
        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        { 
            if (item.ToolTipText != "My Home") //for avoid a error in myself
            {
                gmap.Overlays.Clear();
                var address = "EH3 9JX";
                var locationService = new GoogleLocationService();
                var point = locationService.GetLatLongFromAddress(address);
                var latitude = point.Latitude;
                var longitude = point.Longitude;
                gmap.SetPositionByKeywords("EH3 9JX"); // My home
                GMapOverlay routesOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.green); // My home
                marker.ToolTipText = "My Home";
                routesOverlay.Markers.Add(marker);
                PointLatLng startp = new PointLatLng(latitude, longitude);
                double lat = (double)item.Position.Lat;
                double lng = (double)item.Position.Lng;
                marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red);
                marker.ToolTipText = item.ToolTipText;
                routesOverlay.Markers.Add(marker);
                PointLatLng endp = new PointLatLng(lat, lng);
                GDirections ss;
                var xx = GMapProviders.GoogleMap.GetDirections(out ss, startp, endp, false, false, false, false, true);
                GMapRoute r = new GMapRoute(ss.Route, "My route");
                disLabel.Text = "Distance: " + ss.Distance;
                //GMapOverlay routesOverlay = new GMapOverlay("Myroutes");
                routesOverlay.Routes.Add(r);
                gmap.Overlays.Add(routesOverlay);
                r.Stroke.Width = 2;
                r.Stroke.Color = Color.SeaGreen;
                gmap.ZoomAndCenterMarkers("markers");
                //gmap.Zoom = 8;
                textStepsBox.Clear();
                textStepsBox.Visible = true;
                string steps;
                string dis;
                string time;
                for (int i=0;i< ss.Steps.Count;i++)
                {
                    steps = ss.Steps[i].HtmlInstructions.ToString();
                    dis = ss.Steps[i].Distance.ToString();
                    time = ss.Steps[i].Duration.ToString();
                    steps = Regex.Replace(steps, "<.*?>", string.Empty); //regular expression
                    textStepsBox.AppendText (i+1+"- "+steps +" - "+dis+" - "+time+ "\r\n");
                }
                textStepsBox.SelectionStart = textStepsBox.GetFirstCharIndexFromLine(0); //go to first line
                textStepsBox.ScrollToCaret();
            }
        }
        private void excelButton_Click(object sender, EventArgs e) //export
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[1, j + 1] = dataGridView1.Columns[j].Name.ToString().ToUpper();
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            xlWorkBook.SaveAs("timeWorked.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            //xlApp.Visible = true;
            System.Windows.Forms.MessageBox.Show("Excel file created, timeWorked.xls");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int nFila = dataGridView1.CurrentCell.RowIndex;
            int IdToDel = Int32.Parse(dataGridView1.Rows[nFila].Cells[0].Value.ToString());
            var dbContext = new DemoContext();
            var workDelete = (from p in dbContext.DataWorks.Where(p => p.Id == IdToDel) select p).Single();
            DialogResult result = MessageBox.Show("Delete work", "Important Question", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    dbContext.DataWorks.Remove(workDelete);
                    dbContext.SaveChanges();
                    MessageBox.Show("Work Deleted: " + nFila);
                    break;
                case DialogResult.No:
                    break;
            }
            showDataGridView();
        }

        private void daysWorkedMonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {//si pulsas solo en cambio de las flechas del mes no muestra el datagrid
            string daySelected = daysWorkedMonthCalendar1.SelectionRange.Start.ToShortDateString();
            var dbContext = new DemoContext();
            try
            {
                System.Collections.ObjectModel.ObservableCollection<DataReg> valuesBd = new System.Collections.ObjectModel.ObservableCollection<DataReg>();
                var listBd = from p in dbContext.DataWorks.Where(p => p.dateWork == daySelected) select p;
                decimal earnedDaySelected = 0;
                foreach (var p in listBd)
                {
                    valuesBd.Add(new DataReg() { Id = p.Id, typeWork = p.typeWork, detailsWork = p.detailsWork, siteWork = p.siteWork, zipCode = p.zipCode, dateWork = p.dateWork, timeStartWork = p.timeStartWork, timeFinishWork = p.timeFinishWork, timeWorked = p.timeWorked, earned = p.earned });
                    DateTime DayWorked = DateTime.Parse(p.dateWork.ToString());
                    daysWorkedMonthCalendar1.AddBoldedDate(DayWorked);
                    earnedDaySelected = p.earned + earnedDaySelected;
                }
                earnedDaySelectedLabel.Text = "Earned on Day Selected: £" + earnedDaySelected;
                dataGridView1.DataSource = valuesBd;
            }
            catch { Console.Write("day without any data"); } //Maybe the user select a day without any data
        }

        private void loadAllDataButton1_Click(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int nColum = dataGridView1.CurrentCell.ColumnIndex;
            String strSelect = "";
            if (nColum != 0)
            {
                if ((dataGridView1.CurrentCell.Value) == null)
                    strSelect = "";
                else
                    strSelect = dataGridView1.CurrentCell.Value.ToString();
                int nFileEdit = dataGridView1.CurrentCell.RowIndex;
                EditItem editItem = new EditItem(strSelect, nFileEdit, nColum, this);
                editItem.Show();
            }
            else
            {
                MessageBox.Show("You cannot Edit this field"); //no edit ID field
            }
        }
        public void edit(string strNew, int nFileEdit2, int nColum2)
        {
            int IdToEdit = Int32.Parse(dataGridView1.Rows[nFileEdit2].Cells[0].Value.ToString());
            var dbContext = new DemoContext();
            var regToEdit = (from p in dbContext.DataWorks.Where(p => p.Id == IdToEdit) select p).Single();
            switch (nColum2)
            {
                case 1:
                    regToEdit.typeWork = strNew;
                    break;
                case 2:
                    regToEdit.siteWork = strNew;
                    break;
                case 3:
                    regToEdit.zipCode = strNew;
                    break;
                case 4:
                    regToEdit.detailsWork = strNew;
                    break;
                case 5:
                    regToEdit.dateWork = strNew;
                    break;
                case 6:
                    regToEdit.timeStartWork = strNew;
                    break;
                case 7:
                    regToEdit.timeFinishWork = strNew;
                    break;
                case 8:
                    regToEdit.timeWorked = strNew;
                    break;
                case 9:
                    regToEdit.earned = decimal.Parse(strNew);
                    break;
                case 10:
                    regToEdit.paid = Boolean.Parse(strNew);
                    break;
            }
            dbContext.Entry(regToEdit).CurrentValues.SetValues(regToEdit);
            dbContext.SaveChanges();
            showDataGridView();
            MessageBox.Show("File Edited");
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            //improve: 1-select excel file
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt = 0;
            int cCnt = 0;
            int contAdd = 0;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open("ControlWorkSupermums.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            var dbContext = new DemoContext();
            for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++) //start on sencond row
            {
                var newDataFromExcel = new DataReg();
                for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                {
                    if ((range.Cells[rCnt, cCnt] as Excel.Range).Value2 == null) //when there is null cells on excel
                    {
                        str = "";
                    }
                    else
                    {
                        str = (range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
                    }
                    if (newDataFromExcel.typeWork != "") //execute only if exists a data in the first column
                    {
                        switch (cCnt)
                        {
                            case 1:
                                newDataFromExcel.typeWork = str;
                                break;
                            case 2:
                                double oleDateTime = double.Parse(str);
                                DateTime dt = DateTime.FromOADate(oleDateTime);
                                dt = DateTime.FromOADate(oleDateTime);
                                string date = dt.ToString("dd/MM/yyyy");
                                newDataFromExcel.dateWork = date;
                                break;
                            case 3:
                                double oleDateTime2 = double.Parse(str);
                                DateTime dt2 = DateTime.FromOADate(oleDateTime2);
                                string time = dt2.ToString("HH:mm");
                                newDataFromExcel.timeStartWork = time;
                                break;
                            case 4:
                                double oleDateTime3 = double.Parse(str);
                                DateTime dt3 = DateTime.FromOADate(oleDateTime3);
                                string time2 = dt3.ToString("HH:mm");
                                newDataFromExcel.timeFinishWork = time2;
                                break;
                            case 5:
                                double oleDateTime4 = double.Parse(str);
                                DateTime dt4 = DateTime.FromOADate(oleDateTime4);
                                string time3 = dt4.ToString("HH:mm");
                                newDataFromExcel.timeWorked = time3;
                                break;
                            case 6:
                                newDataFromExcel.siteWork = str;
                                break;
                            case 7:
                                newDataFromExcel.zipCode = str;
                                break;
                            case 8:
                                newDataFromExcel.detailsWork = str;
                                break;
                            case 9:
                                // nothing, it´s coef hours  
                                break;
                            case 10:
                                // nothing, it´s earn per hour 
                                break;
                            case 11:
                                newDataFromExcel.earned = decimal.Parse(str);
                                break;
                            case 14:
                                newDataFromExcel.paid = false;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("First Column empty"); //to stop at final of Excel File
                    }
                }
                if (checkIfRepeat(newDataFromExcel) == false) //clean last rows excel file
                {
                    dbContext.DataWorks.Add(newDataFromExcel);
                    dbContext.SaveChanges();
                    contAdd++;
                }
                else
                {
                    MessageBox.Show("Any new Data in Excel");
                }
            }
            if (contAdd != 0)
                MessageBox.Show(contAdd + " Data Imported");
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            showDataGridView();
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        bool checkIfRepeat(DataReg newDataFromExcel) //to check if there is new data in rows
        {
            int a = 1;
            string dateWorkForCheck = newDataFromExcel.dateWork;
            string typeWorkForCheck = newDataFromExcel.typeWork;
            var dbContext = new DemoContext();
            var listBd = from p in dbContext.DataWorks select p;
            foreach (var p in listBd)
                {
                if ((p.dateWork == dateWorkForCheck) && (p.typeWork == typeWorkForCheck))
                    {
                         a = 1;
                        return true;
                    }
                    else
                    {
                         a = 0;
                        return false;
                    }
                }
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            NewJob formData = new NewJob(this);
            formData.Show();
        }
        private void showGraphics(List<decimal> earnedWeek, List<int> infoNumerOfWeek)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
                                            
            chart1.Series.Add(series1);
            chart1.Titles.Add("Earned per Week");
            chart1.ChartAreas[0].AxisX.Title = "Number Of Week";
            chart1.ChartAreas[0].AxisY.Title = "Earned";
            //chart1.Series["Series1"].IsValueShownAsLabel = true; //label each bar
            for (int i = 0; i < infoNumerOfWeek.Count; i++)
            {
                series1.Points.AddXY(infoNumerOfWeek[i],earnedWeek[i]);

                if ((infoNumerOfWeek[i] % 2) != 0)
                {
                    chart1.Series["Series1"].Points[i].Color = Color.LightGray;
                }
                else
                {
                    chart1.Series["Series1"].Points[i].Color = Color.LightSalmon;
                }
                
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
            if (chart1.Series["Series1"].ChartType == SeriesChartType.Column)
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.FastLine;
            }
            else
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            }
             
        }
    }
}
