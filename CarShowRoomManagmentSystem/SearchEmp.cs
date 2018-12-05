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
    public partial class SearchEmp : Form
    {
        public SearchEmp()
        {
            InitializeComponent();
        }

        private void buttonAddNewCar_Click(object sender, EventArgs e)
        {
            new AddANewCar().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UpdateCar().Show();
        }
    }
}
