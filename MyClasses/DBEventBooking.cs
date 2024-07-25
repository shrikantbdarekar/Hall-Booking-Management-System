using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBookingManagementSystem.MyClasses
{
    public class EventBooking
    {
        public int EventBookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public int CustomerId { get; set; }
        public int PackageId { get; set; }
        public int HallId { get; set; }
        public string BookingTypeId { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventName { get; set; }
        public string EventTypeId { get; set; }
        public string EventDescription { get; set; }
        public int PersonCount { get; set; }
        public string Remark { get; set; }
        public decimal PackageAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? FinalAmount { get; set; }
        public decimal? ReceivedAmount { get; set; }
    }

}
