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

namespace ControlWork
{
    public partial class NewJob : Form
    {
        public decimal earned; //Global var
        public TimeSpan timeWorked;
        private MainPlace newMainWindow = new MainPlace(); //for a assignment
        public NewJob(MainPlace mainWindow)
        {
            Database.SetInitializer<DemoContext>(new CreateDatabaseIfNotExists<DemoContext>());
            InitializeComponent();
            typeWork.SelectedIndex = 0;
            comboBoxHourStart.SelectedIndex = 9;
            comboBoxMinuteStart.SelectedIndex = 0;
            comboBoxHourFinish.SelectedIndex = 10;
            comboBoxMinuteFinish.SelectedIndex = 0;
            newMainWindow = mainWindow;  //assignment from mainWindow
        }
        private decimal typeWorkSelected()
        {
            decimal salaryGross = 7.5m;
            decimal deductions = 0.0m;
            decimal salaryNet = 7.5m;
            var item = typeWork.Text;
            switch (item)
            {
                case "After School":
                    salaryGross = 7.5m;
                    deductions = 0.0m;
                    salaryNet = 7.5m;
                    break;
                case "Nursery":
                    salaryGross = 7.5m;
                    deductions = 0.0m;
                    salaryNet = 7.5m;
                    break;
                case "Nanny":
                    salaryGross = 7.5m;
                    deductions = 0.0m;
                    salaryNet = 7.5m;
                    break;
                case "Babysitting":
                    salaryGross = 7.5m;
                    deductions = 0.0m;
                    salaryNet = 7.5m;
                    break;
                case "Crèche work":
                    salaryGross = 7.5m;
                    deductions = 0.0m;
                    salaryNet = 7.5m;
                    break;
                default:
                    salaryGross = 7.5m;
                    deductions = 0.0m;
                    salaryNet = 7.5m;
                    break;
            }
            return salaryNet;
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            dateWorkLabel.Text = "Date Work: " + monthCalendar1.SelectionRange.Start.ToShortDateString();
            DateTime theTimeStart = Convert.ToDateTime(comboBoxHourStart.Text.ToString() + ":" + comboBoxMinuteStart.Text.ToString());
            DateTime theTimeFinish = Convert.ToDateTime(comboBoxHourFinish.Text.ToString() + ":" + comboBoxMinuteFinish.Text.ToString());
            timeWorked = theTimeFinish.Subtract(theTimeStart);
            timeWorkedLabel.Text = "Time Worked: " + timeWorked.ToString(@"hh\:mm");
            decimal dec = Convert.ToDecimal(TimeSpan.Parse(timeWorked.ToString()).TotalHours);
            decimal salaryNet = typeWorkSelected();
            earned = dec * salaryNet;
            earnedLabel.Text = "Earned: " + earned.ToString() + " £";
        }

        private void addToDBButton_Click(object sender, EventArgs e)
        {
            if (siteTextBox.Text != "")
            {
                var dbContext = new DemoContext();
                var info = new DataReg() { typeWork = typeWork.Text, siteWork = siteTextBox.Text, zipCode = zipCodeTextBox.Text, detailsWork = detailsTextBox.Text, dateWork = monthCalendar1.SelectionRange.Start.ToShortDateString(), timeStartWork = (comboBoxHourStart.Text.ToString() + ":" + comboBoxMinuteStart.Text.ToString()), timeFinishWork = (comboBoxHourFinish.Text.ToString() + ":" + comboBoxMinuteFinish.Text.ToString()), timeWorked = timeWorked.ToString(@"hh\:mm"), earned = earned, paid = false };
                dbContext.DataWorks.Add(info);
                dbContext.SaveChanges();
                MessageBox.Show("Work Saved");
                newMainWindow.showDataGridView();
            }
            else
            {
                MessageBox.Show("Site Work not valid");
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateWorkLabel.Text = "Date Work: " + monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
