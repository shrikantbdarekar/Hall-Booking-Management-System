using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALEventBookings
    {
        private string connectionString = MyConnectioString.Value;

        // Get All EventBookings
        public List<EventBooking> GetAllEventBookings()
        {
            List<EventBooking> eventBookings = new List<EventBooking>();
            string query = "SELECT * FROM EventBookings";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EventBooking eventBooking = new EventBooking
                    {
                        EventBookingId = Convert.ToInt32(reader["EventBookingId"]),
                        //BookingDate = reader["BookingDate"] != DBNull.Value ? Convert.ToDateTime(reader["BookingDate"]) : (DateTime?)null,
                        BookingDate = Convert.ToDateTime(reader["BookingDate"]) ,
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        PackageId = Convert.ToInt32(reader["PackageId"]),
                        //HallId = Convert.ToInt32(reader["HallId"]),
                        BookingTypeId = Convert.ToInt32(reader["BookingTypeId"]),
                        EventDate = Convert.ToDateTime(reader["EventDate"]),
                        EventName = reader["EventName"].ToString(),
                        EventTypeId = Convert.ToInt32(reader["EventTypeId"]),
                        EventDescription = reader["EventDescription"].ToString(),
                        PersonCount = Convert.ToInt32(reader["PersonCount"]),
                        Remark = reader["Remark"].ToString(),
                        PackageAmount = Convert.ToDecimal(reader["PackageAmount"]),
                        DiscountAmount = reader["DiscountAmount"] != DBNull.Value ? Convert.ToDecimal(reader["DiscountAmount"]) : (decimal?)null,
                        FinalAmount = reader["FinalAmount"] != DBNull.Value ? Convert.ToDecimal(reader["FinalAmount"]) : (decimal?)null,
                        ReceivedAmount = reader["ReceivedAmount"] != DBNull.Value ? Convert.ToDecimal(reader["ReceivedAmount"]) : (decimal?)null
                    };
                    eventBookings.Add(eventBooking);
                }
            }
            return eventBookings;
        }

        // Get EventBooking by ID
        public EventBooking GetEventBookingById(int eventBookingId)
        {
            EventBooking eventBooking = null;
            string query = "SELECT * FROM EventBookings WHERE EventBookingId = @EventBookingId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventBookingId", eventBookingId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    eventBooking = new EventBooking
                    {
                        EventBookingId = Convert.ToInt32(reader["EventBookingId"]),
                        BookingDate = Convert.ToDateTime(reader["BookingDate"]),
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        PackageId = Convert.ToInt32(reader["PackageId"]),
                        //HallId = Convert.ToInt32(reader["HallId"]),
                        BookingTypeId = Convert.ToInt32(reader["BookingTypeId"]),
                        EventDate = Convert.ToDateTime(reader["EventDate"]),
                        EventName = reader["EventName"].ToString(),
                        EventTypeId = Convert.ToInt32(reader["EventTypeId"]),
                        EventDescription = reader["EventDescription"].ToString(),
                        PersonCount = Convert.ToInt32(reader["PersonCount"]),
                        Remark = reader["Remark"].ToString(),
                        PackageAmount = Convert.ToDecimal(reader["PackageAmount"]),
                        DiscountAmount = reader["DiscountAmount"] != DBNull.Value ? Convert.ToDecimal(reader["DiscountAmount"]) : (decimal?)null,
                        FinalAmount = reader["FinalAmount"] != DBNull.Value ? Convert.ToDecimal(reader["FinalAmount"]) : (decimal?)null,
                        ReceivedAmount = reader["ReceivedAmount"] != DBNull.Value ? Convert.ToDecimal(reader["ReceivedAmount"]) : (decimal?)null
                    };
                }
            }
            return eventBooking;
        }

        // Insert EventBooking
        public void InsertEventBooking(EventBooking eventBooking)
        {
            string query = "INSERT INTO EventBookings (BookingDate, CustomerId, PackageId, BookingTypeId, EventDate, EventName, EventTypeId, EventDescription, PersonCount, Remark, PackageAmount, DiscountAmount, FinalAmount, ReceivedAmount) VALUES (@BookingDate, @CustomerId, @PackageId, @BookingTypeId, @EventDate, @EventName, @EventTypeId, @EventDescription, @PersonCount, @Remark, @PackageAmount, @DiscountAmount, @FinalAmount, @ReceivedAmount)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@BookingDate", eventBooking.BookingDate.HasValue ? (object)eventBooking.BookingDate.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@BookingDate", eventBooking.BookingDate);
                cmd.Parameters.AddWithValue("@CustomerId", eventBooking.CustomerId);
                cmd.Parameters.AddWithValue("@PackageId", eventBooking.PackageId);
                //cmd.Parameters.AddWithValue("@HallId", eventBooking.HallId);
                cmd.Parameters.AddWithValue("@BookingTypeId", eventBooking.BookingTypeId);
                cmd.Parameters.AddWithValue("@EventDate", eventBooking.EventDate);
                cmd.Parameters.AddWithValue("@EventName", eventBooking.EventName);
                cmd.Parameters.AddWithValue("@EventTypeId", eventBooking.EventTypeId);
                cmd.Parameters.AddWithValue("@EventDescription", eventBooking.EventDescription ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PersonCount", eventBooking.PersonCount);
                cmd.Parameters.AddWithValue("@Remark", eventBooking.Remark ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PackageAmount", eventBooking.PackageAmount);
                cmd.Parameters.AddWithValue("@DiscountAmount", eventBooking.DiscountAmount.HasValue ? (object)eventBooking.DiscountAmount.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@FinalAmount", eventBooking.FinalAmount.HasValue ? (object)eventBooking.FinalAmount.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReceivedAmount", eventBooking.ReceivedAmount.HasValue ? (object)eventBooking.ReceivedAmount.Value : DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update EventBooking
        public void UpdateEventBooking(EventBooking eventBooking)
        {
            string query = "UPDATE EventBookings SET BookingDate = @BookingDate, CustomerId = @CustomerId, PackageId = @PackageId, BookingTypeId = @BookingTypeId, EventDate = @EventDate, EventName = @EventName, EventTypeId = @EventTypeId, EventDescription = @EventDescription, PersonCount = @PersonCount, Remark = @Remark, PackageAmount = @PackageAmount, DiscountAmount = @DiscountAmount, FinalAmount = @FinalAmount WHERE EventBookingId = @EventBookingId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventBookingId", eventBooking.EventBookingId);
                cmd.Parameters.AddWithValue("@BookingDate", eventBooking.BookingDate);
                //cmd.Parameters.AddWithValue("@BookingDate", eventBooking.BookingDate.HasValue ? (object)eventBooking.BookingDate.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@CustomerId", eventBooking.CustomerId);
                cmd.Parameters.AddWithValue("@PackageId", eventBooking.PackageId);
                //cmd.Parameters.AddWithValue("@HallId", eventBooking.HallId);
                cmd.Parameters.AddWithValue("@BookingTypeId", eventBooking.BookingTypeId);
                cmd.Parameters.AddWithValue("@EventDate", eventBooking.EventDate);
                cmd.Parameters.AddWithValue("@EventName", eventBooking.EventName);
                cmd.Parameters.AddWithValue("@EventTypeId", eventBooking.EventTypeId);
                cmd.Parameters.AddWithValue("@EventDescription", eventBooking.EventDescription ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PersonCount", eventBooking.PersonCount);
                cmd.Parameters.AddWithValue("@Remark", eventBooking.Remark ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PackageAmount", eventBooking.PackageAmount);
                cmd.Parameters.AddWithValue("@DiscountAmount", eventBooking.DiscountAmount.HasValue ? (object)eventBooking.DiscountAmount.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@FinalAmount", eventBooking.FinalAmount.HasValue ? (object)eventBooking.FinalAmount.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReceivedAmount", eventBooking.ReceivedAmount.HasValue ? (object)eventBooking.ReceivedAmount.Value : DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete EventBooking
        public void DeleteEventBooking(int eventBookingId)
        {
            string query = "DELETE FROM EventBookings WHERE EventBookingId = @EventBookingId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventBookingId", eventBookingId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update EventBooking-ReceivedAmount
        public void UpdateEventBookingReceivedAmount(int EventBookingId, decimal ReceivedAmount)
        {
            string query = "UPDATE EventBookings SET ReceivedAmount += @ReceivedAmount WHERE EventBookingId = @EventBookingId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventBookingId", EventBookingId);
                cmd.Parameters.AddWithValue("@ReceivedAmount", ReceivedAmount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update EventBooking-ReceivedAmountReset
        public void UpdateEventBookingReceivedAmountReset(int EventBookingId, decimal ReceivedAmount)
        {
            string query = "UPDATE EventBookings SET ReceivedAmount -= @ReceivedAmount WHERE EventBookingId = @EventBookingId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventBookingId", EventBookingId);
                cmd.Parameters.AddWithValue("@ReceivedAmount", ReceivedAmount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<EventBookingDropDown> GetEventBookingsDropDown()
        {
            List<EventBookingDropDown> eventBookings = new List<EventBookingDropDown>();
            string query = "SELECT * FROM EventBookings";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EventBookingDropDown EventBookingDropDownObj = new EventBookingDropDown
                    {
                        EventBookingId = Convert.ToInt32(reader["EventBookingId"]),
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        PackageId = Convert.ToInt32(reader["PackageId"]),
                        BookingTypeId = Convert.ToInt32(reader["BookingTypeId"]),
                        EventName = reader["EventName"].ToString(),
                        EventTypeId = Convert.ToInt32(reader["EventTypeId"]),
                        FinalAmount = Convert.ToDecimal(reader["FinalAmount"]),
                        ReceivedAmount = Convert.ToDecimal(reader["ReceivedAmount"])
                    };
                    eventBookings.Add(EventBookingDropDownObj);
                }
            }
            return eventBookings;
        }

        // Get Bookings Report
        public List<BookingReport> GetBookingReport()
        {
            List<BookingReport> bookingReportList = new List<BookingReport>();
            //string query = "Select B.EventBookingId,B.EventDate,B.EventName,C.CustomerName,P.PackageName," +
            //        "H.HallId,H.HallName,T.BookingTypeName " +
            //        "From EventBookings B "+
            //        "Join BookingPackages P on B.PackageId = P.PackageId "+
            //        "Join Halls H On P.HallId = H.HallId "+
            //        "Join Customers C On B.CustomerId = C.CustomerId "+
            //        "Join BookingType T On B.BookingTypeId = T.BookingTypeId";

            string query = "Select B.EventBookingId,B.EventDate,B.EventName,C.CustomerName,P.PackageName," +
                    "H.HallId,H.HallName,T.BookingTypeName " +
                    "From EventBookings B " +
                    "Left Outer Join BookingPackages P on B.PackageId = P.PackageId " +
                    "Left Outer Join Halls H On P.HallId = H.HallId " +
                    "Left Outer Join Customers C On B.CustomerId = C.CustomerId " +
                    "Left Outer Join BookingType T On B.BookingTypeId = T.BookingTypeId "+
                    "Order By H.HallName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BookingReport bookingReport = new BookingReport
                    {
                        EventBookingId = Convert.ToInt32(reader["EventBookingId"]),
                        EventDate = Convert.ToDateTime(reader["EventDate"]),
                        EventName = reader["EventName"].ToString(),
                        CustomerName = reader["CustomerName"].ToString(),
                        PackageName = reader["PackageName"].ToString(),
                        HallId = Convert.ToInt32(reader["HallId"]),
                        HallName = reader["HallName"].ToString(),
                        BookingTypeName = reader["BookingTypeName"].ToString()
                    };
                    bookingReportList.Add(bookingReport);
                }
            }
            return bookingReportList;
        }

    }
}
