using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Entity
{
    public interface IPerson
    {
        string Name { get; set; } 
        string Email { get; set;}
        string Phone { get; set; }
        DateTime DateOfbirth { get; set; }
    }
}
