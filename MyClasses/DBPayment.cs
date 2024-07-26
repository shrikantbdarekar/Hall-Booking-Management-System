using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBookingManagementSystem.MyClasses
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int EventBookingId { get; set; }
        public decimal DueAmount { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public string Remark { get; set; }
    }

    public class CollectionReport
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string EventName { get; set; }
        public string CustomerName { get; set; }
        public string Remark { get; set; }
        public decimal PaymentAmount { get; set; }
    }

}
