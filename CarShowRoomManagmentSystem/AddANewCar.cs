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
    public partial class AddANewCar : Form
    {
        public AddANewCar()
        {
            InitializeComponent();
        }

        private void buttonCancelCar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
