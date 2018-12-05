using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Entity
{
    public class Order
    {
        enum SelectBrand
        {
            AUDI =0,
            BMW = 1
        }
        enum SelectShowRoom
        {
            Banani = 0,
            Gulshan = 1,
            Dhonmondi = 2 
        }
        enum Payment
        {
            Loan  = 0,
            Cash = 1,
            Installment = 2
        }
        public string EmpId { get; set; }
        public string CustomerId { get; set; }
        private static int count;
        private string orderId;
        public Order()
        {
           orderId = (++count).ToString("D4");
      
        }


    }
}
