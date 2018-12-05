using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Entity
{
    enum Gender
    {
       Male = 0,
       Female =1
    }
    public class Customer : IPerson
    {
        private static int  count;
        private string customerId;
        
        public Customer()
        {
           customerId = DateTime.Now.Month.ToString();
           customerId = customerId + (++count).ToString("D5");
        }
        private string adderss;
        public string Adderss
        {
            get
            {
                return this.adderss;
            }

            set
            {
                this.adderss  = value;
            }
        }
        public string CustomerId
        {
            get
            {
                return this.customerId;
            }
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
    }
}
