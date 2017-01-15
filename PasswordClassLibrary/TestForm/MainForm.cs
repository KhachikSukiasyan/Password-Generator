using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordClassLibrary;

namespace TestForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        // button
        private void mainButton_MouseClick(object sender, MouseEventArgs e)
        {
            resultTextBox.Text = "afagfdgsfhsghfg";
        }


        // checkboxes
        private void digitCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            checkboxPress();
            if (digitCheckBox.Checked)
            {
                dFrom.Enabled = true;
                dTo.Enabled = true;
                digit1UpDown.Enabled = true;
                digit2UpDown.Enabled = true;
            }
            else
            {
                dFrom.Enabled = false;
                dTo.Enabled = false;
                digit1UpDown.Enabled = false;
                digit2UpDown.Enabled = false;
            }
        }

        private void lowCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            checkboxPress();

            if (lowCheckBox.Checked)
            {
                lFrom.Enabled = true;
                lTo.Enabled = true;
                lComboBox1.Enabled = true;
                lComboBox2.Enabled = true;
            }
            else
            {
                lFrom.Enabled = false;
                lTo.Enabled = false;
                lComboBox1.Enabled = false;
                lComboBox2.Enabled = false;
            }
        }

        private void upCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            checkboxPress();

            if (upCheckBox.Checked)
            {
                uFrom.Enabled = true;
                uTo.Enabled = true;
                uComboBox1.Enabled = true;
                uComboBox2.Enabled = true;
            }
            else
            {
                uFrom.Enabled = false;
                uTo.Enabled = false;
                uComboBox1.Enabled = false;
                uComboBox2.Enabled = false;
            }
        }


        private void mulPassCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (mulPassCheckBox.Checked)
               passCountTextBox.Enabled = true;
            else
                passCountTextBox.Enabled = false;

        }

        // helpers
        void checkboxPress()
        {
            if (!digitCheckBox.Checked && !lowCheckBox.Checked && !upCheckBox.Checked)
            {
               DialogResult res = MessageBox.Show("You must check at least one", "Note", MessageBoxButtons.OK);
               if (res == DialogResult.OK)
               {
                   digitCheckBox.Checked = true;
                   dFrom.Enabled = true;
                   dTo.Enabled = true;
                   digit1UpDown.Enabled = true;
                   digit2UpDown.Enabled = true;
               }
            }
        }

    }
}
