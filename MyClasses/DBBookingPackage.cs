using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBookingManagementSystem.MyClasses
{
    public class BookingPackage
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public decimal PackageAmount { get; set; }
        public string PackageDescription { get; set; }
        public int HallId { get; set; }
    }

}
