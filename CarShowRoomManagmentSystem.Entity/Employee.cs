using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Entity
{
    enum Depatment
    {
        Sales =0,
        Marketing = 1,
        Delivery =2
    }

    enum Branch
    {
        Banani =0,
        Gulshan = 1,
        Dhanmondhi = 2,
    }
    enum Sex
    {
        Male =0,
        Female =1
    }
    public class Employee : IPerson
    {
        private static int count;
        private string empId;
        public Employee()
        {
            empId = DateTime.Now.Year.ToString();
            empId = empId + (++count).ToString("D5");
        }
        public DateTime DateOfbirth
        {
            get
            {
                return this.DateOfbirth;
            }

            set
            {
                this.DateOfbirth = value;
            }
        }

        public string Email
        {
            get
            {
                return this.Email;
            }

            set
            {
                this.Email = value;
            }
        }

        public string Id
        {
            get
            {
                return this.Id;
            }
        }

        public string Name
        {
            get
            {
                return this.Name;
            }

            set
            {
                this.Name = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.Phone;
            }

            set
            {
                this.Phone = value;
            }
        }

        public ushort Salary { set; get; }
        public DateTime EmpJoinDate { set; get; }
    }
}
