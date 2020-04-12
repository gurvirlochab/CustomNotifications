using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomNotifications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDialogBox_Click(object sender, EventArgs e)
        {
            NotificationClasses.DialogFormDisplay nxtfrm = new NotificationClasses.DialogFormDisplay();
            nxtfrm.Display(
                "YesNo", 
                "This is a Title", 
                "This is a dialog box. You can choose to press Yes for more action or No to discard the dialog box\nOption 1\nOption 2\nOption 3"
                );
            nxtfrm.ShowDialog();
        }
    }
}
