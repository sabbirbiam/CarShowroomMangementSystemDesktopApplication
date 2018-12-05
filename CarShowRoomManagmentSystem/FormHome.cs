using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowRoomManagmentSystem
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void wITHALOGINIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginFrom().Show();
        }

        private void wITHOUTALOGINIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerReg().Show();
        }

        
    }
}
