﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBookingManagementSystem.MyClasses
{
    public class EventBooking
    {
        public int EventBookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int CustomerId { get; set; }
        public int PackageId { get; set; }
        //public int HallId { get; set; }
        public int BookingTypeId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public int EventTypeId { get; set; }
        public string EventDescription { get; set; }
        public int PersonCount { get; set; }
        public string Remark { get; set; }
        public decimal PackageAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? FinalAmount { get; set; }
        public decimal? ReceivedAmount { get; set; }
    }

    public class EventBookingDropDown
    {
        public int EventBookingId { get; set; }
        public int CustomerId { get; set; }
        public int PackageId { get; set; }
        public int HallId { get; set; }
        public int BookingTypeId { get; set; }
        public string EventName { get; set; }
        public int EventTypeId { get; set; }
        public decimal FinalAmount { get; set; }
        public decimal ReceivedAmount { get; set; }

        public decimal DueAmount { get { return FinalAmount - ReceivedAmount; } }
    }
    public class BookingReport
    {
        public int EventBookingId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string CustomerName { get; set; }
        public string PackageName { get; set; }
        public int HallId { get; set; }
        public string HallName { get; set; }
        public string BookingTypeName { get; set; }
    }

    public class DueReport
    {
        public int EventBookingId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public decimal FinalAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal DueAmount { get; set; }
    }

    



}
