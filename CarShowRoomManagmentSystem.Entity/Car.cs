using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Entity
{
    
    enum FuleType
    {
        Petrol = 0,
        Desel = 1,
        CNG = 2
    };
    //enum CarColor
    //{
    //    blue,white,black,green
    //};
   public  class Car
    {
        public string  CarId { get;}
        public string CarName { get; set; }
        public string CarManCompany { get; set; }
        public double CarPrice { get; set; }
        public ushort CarSpeed { get; set; }
        public string CarEngineId { get; set; }
        public ushort NumberOfSet { get; set; }
        public DateTime CarPublishedDate { get; set; } 
        public string CarColor { get; set; }
        enum CarTypes
        {
            OradinaryCar = 0,
            SportingCar = 1
        };
    }
}
