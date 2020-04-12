using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomNotifications.NotificationClasses
{
    public partial class DialogFormDisplay : Form
    {
        public DialogFormDisplay()
        {
            InitializeComponent();
        }
        string dialogcode;
        public void Display(string code, string title, string description)
        {
            dialogcode = code;
            switch (code)
            {
                case "YesNo":
                    btnLeft.Text = "Yes";
                    btnLeft.BackColor = Color.ForestGreen;
                    //btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                    btnLeft.ForeColor = Color.White;
                    btnRight.Text = "No";
                    btnRight.BackColor = Color.Red;
                    btnRight.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
            displayTitle.Text = title;
            displayMessage.Text = description;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            dialogResultLeft(dialogcode);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            dialogResultRight(dialogcode);
        }
        void dialogResultLeft(string code)
        {
            switch (code)
            {
                case "YesNo":
                    DialogResult = DialogResult.Yes;
                    MessageBox.Show("You pressed " + DialogResult);
                    break;
                default:
                    break;
            }
        }
        void dialogResultRight(string code)
        {
            switch (code)
            {
                case "YesNo":
                    DialogResult = DialogResult.No;
                    MessageBox.Show("You pressed " + DialogResult);
                    break;
                default:
                    break;
            }
        }
    }
}
