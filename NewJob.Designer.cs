namespace ControlWork
{
    partial class NewJob
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.earnedLabel = new System.Windows.Forms.Label();
            this.comboBoxHourStart = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuteStart = new System.Windows.Forms.ComboBox();
            this.typeWork = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxHourFinish = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuteFinish = new System.Windows.Forms.ComboBox();
            this.timeWorkedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.dateWorkLabel = new System.Windows.Forms.Label();
            this.addToDBButton = new System.Windows.Forms.Button();
            this.zipCodeLabel1 = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // earnedLabel
            // 
            this.earnedLabel.AutoSize = true;
            this.earnedLabel.Location = new System.Drawing.Point(214, 249);
            this.earnedLabel.Name = "earnedLabel";
            this.earnedLabel.Size = new System.Drawing.Size(41, 13);
            this.earnedLabel.TabIndex = 1;
            this.earnedLabel.Text = "Earned";
            // 
            // comboBoxHourStart
            // 
            this.comboBoxHourStart.FormattingEnabled = true;
            this.comboBoxHourStart.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHourStart.Location = new System.Drawing.Point(274, 174);
            this.comboBoxHourStart.Name = "comboBoxHourStart";
            this.comboBoxHourStart.Size = new System.Drawing.Size(46, 21);
            this.comboBoxHourStart.TabIndex = 7;
            // 
            // comboBoxMinuteStart
            // 
            this.comboBoxMinuteStart.FormattingEnabled = true;
            this.comboBoxMinuteStart.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxMinuteStart.Location = new System.Drawing.Point(326, 174);
            this.comboBoxMinuteStart.Name = "comboBoxMinuteStart";
            this.comboBoxMinuteStart.Size = new System.Drawing.Size(46, 21);
            this.comboBoxMinuteStart.TabIndex = 8;
            // 
            // typeWork
            // 
            this.typeWork.FormattingEnabled = true;
            this.typeWork.Items.AddRange(new object[] {
            "After School",
            "Nursery",
            "Nanny",
            "Babysitting",
            "Crèche work"});
            this.typeWork.Location = new System.Drawing.Point(217, 18);
            this.typeWork.Name = "typeWork";
            this.typeWork.Size = new System.Drawing.Size(90, 21);
            this.typeWork.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time Finish";
            // 
            // comboBoxHourFinish
            // 
            this.comboBoxHourFinish.FormattingEnabled = true;
            this.comboBoxHourFinish.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHourFinish.Location = new System.Drawing.Point(274, 197);
            this.comboBoxHourFinish.Name = "comboBoxHourFinish";
            this.comboBoxHourFinish.Size = new System.Drawing.Size(46, 21);
            this.comboBoxHourFinish.TabIndex = 12;
            // 
            // comboBoxMinuteFinish
            // 
            this.comboBoxMinuteFinish.FormattingEnabled = true;
            this.comboBoxMinuteFinish.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxMinuteFinish.Location = new System.Drawing.Point(326, 197);
            this.comboBoxMinuteFinish.Name = "comboBoxMinuteFinish";
            this.comboBoxMinuteFinish.Size = new System.Drawing.Size(46, 21);
            this.comboBoxMinuteFinish.TabIndex = 13;
            // 
            // timeWorkedLabel
            // 
            this.timeWorkedLabel.AutoSize = true;
            this.timeWorkedLabel.Location = new System.Drawing.Point(214, 228);
            this.timeWorkedLabel.Name = "timeWorkedLabel";
            this.timeWorkedLabel.Size = new System.Drawing.Size(71, 13);
            this.timeWorkedLabel.TabIndex = 14;
            this.timeWorkedLabel.Text = "Time Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Details";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(217, 135);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(148, 20);
            this.detailsTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Site";
            // 
            // siteTextBox
            // 
            this.siteTextBox.Location = new System.Drawing.Point(217, 58);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(148, 20);
            this.siteTextBox.TabIndex = 18;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(18, 201);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 19;
            this.calculateButton.Text = "Calulate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // dateWorkLabel
            // 
            this.dateWorkLabel.AutoSize = true;
            this.dateWorkLabel.Location = new System.Drawing.Point(214, 158);
            this.dateWorkLabel.Name = "dateWorkLabel";
            this.dateWorkLabel.Size = new System.Drawing.Size(62, 13);
            this.dateWorkLabel.TabIndex = 20;
            this.dateWorkLabel.Text = "Date Work:";
            // 
            // addToDBButton
            // 
            this.addToDBButton.Location = new System.Drawing.Point(18, 239);
            this.addToDBButton.Name = "addToDBButton";
            this.addToDBButton.Size = new System.Drawing.Size(75, 23);
            this.addToDBButton.TabIndex = 21;
            this.addToDBButton.Text = "Add to DB";
            this.addToDBButton.UseVisualStyleBackColor = true;
            this.addToDBButton.Click += new System.EventHandler(this.addToDBButton_Click);
            // 
            // zipCodeLabel1
            // 
            this.zipCodeLabel1.AutoSize = true;
            this.zipCodeLabel1.Location = new System.Drawing.Point(214, 80);
            this.zipCodeLabel1.Name = "zipCodeLabel1";
            this.zipCodeLabel1.Size = new System.Drawing.Size(50, 13);
            this.zipCodeLabel1.TabIndex = 23;
            this.zipCodeLabel1.Text = "Zip Code";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(217, 96);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(148, 20);
            this.zipCodeTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.zipCodeLabel1);
            this.Controls.Add(this.addToDBButton);
            this.Controls.Add(this.dateWorkLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeWorkedLabel);
            this.Controls.Add(this.comboBoxMinuteFinish);
            this.Controls.Add(this.comboBoxHourFinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeWork);
            this.Controls.Add(this.comboBoxMinuteStart);
            this.Controls.Add(this.comboBoxHourStart);
            this.Controls.Add(this.earnedLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Insert Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label earnedLabel;
        private System.Windows.Forms.ComboBox comboBoxHourStart;
        private System.Windows.Forms.ComboBox comboBoxMinuteStart;
        private System.Windows.Forms.ComboBox typeWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxHourFinish;
        private System.Windows.Forms.ComboBox comboBoxMinuteFinish;
        private System.Windows.Forms.Label timeWorkedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label dateWorkLabel;
        private System.Windows.Forms.Button addToDBButton;
        private System.Windows.Forms.Label zipCodeLabel1;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Button button1;
    }
}

