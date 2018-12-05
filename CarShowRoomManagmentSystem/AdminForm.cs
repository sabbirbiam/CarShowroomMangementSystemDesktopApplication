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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void aDDANEWCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddANewCar().Show();
        }

        private void dELETEACARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uPDATEACARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateCar().Show();
        }

        private void iNSERTANEWEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddAEmployee().Show();
        }

        private void dELETEANEWEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uPDATEAEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchEmp().Show();
        }

        private void sEARCHACARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchCar().Show();
        }

        private void sEARCHAEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchEmp().Show();
        }
    }
}
