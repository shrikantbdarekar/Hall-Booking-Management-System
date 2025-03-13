using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBookingManagementSystem.MyClasses
{
    class MyConnectioString
    {
        public static string Value
        {
            get
            {
                // Without user id and password
                // return Properties.Settings.Default.ConnestionStringShort;
                //return "Server=.\\sqlexpress19;Database=HallBookingDb;Integrated Security=True;";
                return "Server=.\\sqlexpress22;Database=HallBookingDb;Integrated Security=True;";

                // With user id and password
                // return Properties.Settings.Default.ConnestionStringFull;
                //return "Server=.\\sqlexpress19;Database=HallBookingDb;User Id=sa;Password=pass@1234;";
                //return "Server=.\\sqlexpress22;Database=HallBookingDb;User Id=sa;Password=pass@1234;";
            }
        }
    }
}
