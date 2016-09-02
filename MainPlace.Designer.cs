namespace ControlWork
{
    partial class MainPlace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.daysWorkedMonthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.loadAllDataButton1 = new System.Windows.Forms.Button();
            this.totalEarnedLabel1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.earnedDaySelectedLabel = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.importButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.disLabel = new System.Windows.Forms.Label();
            this.textStepsBox = new System.Windows.Forms.TextBox();
            this.earnedAfterSchoolLabel = new System.Windows.Forms.Label();
            this.earnedBreakfastLabel = new System.Windows.Forms.Label();
            this.earnedCrecheLabel = new System.Windows.Forms.Label();
            this.earnedNurseryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(915, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.editButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.Location = new System.Drawing.Point(239, 353);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(87, 23);
            this.excelButton.TabIndex = 1;
            this.excelButton.Text = "Export to Excel";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(241, 440);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(87, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // daysWorkedMonthCalendar1
            // 
            this.daysWorkedMonthCalendar1.AccessibleDescription = "M";
            this.daysWorkedMonthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daysWorkedMonthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.daysWorkedMonthCalendar1.ForeColor = System.Drawing.Color.Red;
            this.daysWorkedMonthCalendar1.Location = new System.Drawing.Point(18, 295);
            this.daysWorkedMonthCalendar1.Name = "daysWorkedMonthCalendar1";
            this.daysWorkedMonthCalendar1.TabIndex = 3;
            this.daysWorkedMonthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.daysWorkedMonthCalendar1_DateChanged);
            // 
            // loadAllDataButton1
            // 
            this.loadAllDataButton1.Location = new System.Drawing.Point(239, 324);
            this.loadAllDataButton1.Name = "loadAllDataButton1";
            this.loadAllDataButton1.Size = new System.Drawing.Size(85, 23);
            this.loadAllDataButton1.TabIndex = 4;
            this.loadAllDataButton1.Text = "All Days";
            this.loadAllDataButton1.UseVisualStyleBackColor = true;
            this.loadAllDataButton1.Click += new System.EventHandler(this.loadAllDataButton1_Click);
            // 
            // totalEarnedLabel1
            // 
            this.totalEarnedLabel1.AutoSize = true;
            this.totalEarnedLabel1.Location = new System.Drawing.Point(967, 227);
            this.totalEarnedLabel1.Name = "totalEarnedLabel1";
            this.totalEarnedLabel1.Size = new System.Drawing.Size(68, 13);
            this.totalEarnedLabel1.TabIndex = 5;
            this.totalEarnedLabel1.Text = "Total Earned";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(241, 411);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(85, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // earnedDaySelectedLabel
            // 
            this.earnedDaySelectedLabel.AutoSize = true;
            this.earnedDaySelectedLabel.Location = new System.Drawing.Point(967, 324);
            this.earnedDaySelectedLabel.Name = "earnedDaySelectedLabel";
            this.earnedDaySelectedLabel.Size = new System.Drawing.Size(125, 13);
            this.earnedDaySelectedLabel.TabIndex = 7;
            this.earnedDaySelectedLabel.Text = "Earned on day selected: ";
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(515, 295);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 22;
            this.gmap.MinZoom = 10;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(418, 297);
            this.gmap.TabIndex = 8;
            this.gmap.Zoom = 10D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(241, 382);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(85, 23);
            this.importButton.TabIndex = 9;
            this.importButton.Text = "Import from Excel";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1162, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 121);
            this.listBox1.TabIndex = 11;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(239, 295);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(85, 23);
            this.insertButton.TabIndex = 12;
            this.insertButton.Text = "Insert Job";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(970, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(308, 199);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // disLabel
            // 
            this.disLabel.AutoSize = true;
            this.disLabel.Location = new System.Drawing.Point(512, 606);
            this.disLabel.Name = "disLabel";
            this.disLabel.Size = new System.Drawing.Size(46, 13);
            this.disLabel.TabIndex = 15;
            this.disLabel.Text = "disLabel";
            // 
            // textStepsBox
            // 
            this.textStepsBox.Location = new System.Drawing.Point(12, 481);
            this.textStepsBox.Multiline = true;
            this.textStepsBox.Name = "textStepsBox";
            this.textStepsBox.ReadOnly = true;
            this.textStepsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textStepsBox.Size = new System.Drawing.Size(408, 125);
            this.textStepsBox.TabIndex = 17;
            // 
            // earnedAfterSchoolLabel
            // 
            this.earnedAfterSchoolLabel.AutoSize = true;
            this.earnedAfterSchoolLabel.Location = new System.Drawing.Point(967, 252);
            this.earnedAfterSchoolLabel.Name = "earnedAfterSchoolLabel";
            this.earnedAfterSchoolLabel.Size = new System.Drawing.Size(132, 13);
            this.earnedAfterSchoolLabel.TabIndex = 18;
            this.earnedAfterSchoolLabel.Text = "Earned After School Club: ";
            // 
            // earnedBreakfastLabel
            // 
            this.earnedBreakfastLabel.AutoSize = true;
            this.earnedBreakfastLabel.Location = new System.Drawing.Point(967, 266);
            this.earnedBreakfastLabel.Name = "earnedBreakfastLabel";
            this.earnedBreakfastLabel.Size = new System.Drawing.Size(116, 13);
            this.earnedBreakfastLabel.TabIndex = 19;
            this.earnedBreakfastLabel.Text = "Earned Breakfast Club:";
            // 
            // earnedCrecheLabel
            // 
            this.earnedCrecheLabel.AutoSize = true;
            this.earnedCrecheLabel.Location = new System.Drawing.Point(967, 279);
            this.earnedCrecheLabel.Name = "earnedCrecheLabel";
            this.earnedCrecheLabel.Size = new System.Drawing.Size(81, 13);
            this.earnedCrecheLabel.TabIndex = 20;
            this.earnedCrecheLabel.Text = "Earned Creche:";
            // 
            // earnedNurseryLabel
            // 
            this.earnedNurseryLabel.AutoSize = true;
            this.earnedNurseryLabel.Location = new System.Drawing.Point(967, 292);
            this.earnedNurseryLabel.Name = "earnedNurseryLabel";
            this.earnedNurseryLabel.Size = new System.Drawing.Size(83, 13);
            this.earnedNurseryLabel.TabIndex = 21;
            this.earnedNurseryLabel.Text = "Earned Nursery:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1307, 631);
            this.Controls.Add(this.earnedNurseryLabel);
            this.Controls.Add(this.earnedCrecheLabel);
            this.Controls.Add(this.earnedBreakfastLabel);
            this.Controls.Add(this.earnedAfterSchoolLabel);
            this.Controls.Add(this.textStepsBox);
            this.Controls.Add(this.disLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.earnedDaySelectedLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.totalEarnedLabel1);
            this.Controls.Add(this.loadAllDataButton1);
            this.Controls.Add(this.daysWorkedMonthCalendar1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Work";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.MonthCalendar daysWorkedMonthCalendar1;
        private System.Windows.Forms.Button loadAllDataButton1;
        private System.Windows.Forms.Label totalEarnedLabel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label earnedDaySelectedLabel;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label disLabel;
        private System.Windows.Forms.TextBox textStepsBox;
        private System.Windows.Forms.Label earnedAfterSchoolLabel;
        private System.Windows.Forms.Label earnedBreakfastLabel;
        private System.Windows.Forms.Label earnedCrecheLabel;
        private System.Windows.Forms.Label earnedNurseryLabel;
    }
}