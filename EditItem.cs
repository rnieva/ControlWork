using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class EditItem : Form
    {
        private string strNew;
        private int nFileEdit2;
        private int nColum2;
        private bool flagCheckBox=false;
        private MainPlace newMainPlace = new MainPlace(); //for a assignment
        public EditItem(String strSelect, int nFileEdit, int nColum, MainPlace form)
        {
            InitializeComponent();
            if ((strSelect == "False") || (strSelect == "True"))
            {
                paidCheckBox.Show();
                paidCheckBox.Checked = Boolean.Parse(strSelect);
                textBox1Edit.Hide();
                flagCheckBox = true;
            }
            textBox1Edit.Text = strSelect; //field for edit from Form2
            newMainPlace = form;  //assignment from form (2 original to new form)
            nFileEdit2 = nFileEdit; //to know later the ID number
            nColum2 = nColum; //to know later the field to edit
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (flagCheckBox == true)
            {
                strNew = paidCheckBox.Checked.ToString();      
            }
            else
            {
                strNew = textBox1Edit.Text;
            }
            newMainPlace.edit(strNew, nFileEdit2, nColum2);
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
