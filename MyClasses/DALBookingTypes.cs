using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALBookingTypes
    {
        private string connectionString = MyConnectioString.Value;

        // Get All BookingTypes
        public List<BookingType> GetAllBookingTypes()
        {
            List<BookingType> bookingTypes = new List<BookingType>();
            string query = "SELECT * FROM BookingType";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BookingType bookingType = new BookingType
                    {
                        BookingTypeId = Convert.ToInt32(reader["BookingTypeId"]),
                        BookingTypeName = reader["BookingTypeName"].ToString(),
                        BookingTypeDescription = reader["BookingTypeDescription"].ToString()
                    };
                    bookingTypes.Add(bookingType);
                }
            }
            return bookingTypes;
        }

        // Get BookingType by ID
        public BookingType GetBookingTypeById(int bookingTypeId)
        {
            BookingType bookingType = null;
            string query = "SELECT * FROM BookingType WHERE BookingTypeId = @BookingTypeId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingTypeId", bookingTypeId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bookingType = new BookingType
                    {
                        BookingTypeId = Convert.ToInt32(reader["BookingTypeId"]),
                        BookingTypeName = reader["BookingTypeName"].ToString(),
                        BookingTypeDescription = reader["BookingTypeDescription"].ToString()
                    };
                }
            }
            return bookingType;
        }

        // Insert BookingType
        public void InsertBookingType(BookingType bookingType)
        {
            string query = "INSERT INTO BookingType (BookingTypeName, BookingTypeDescription) VALUES (@BookingTypeName, @BookingTypeDescription)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingTypeName", bookingType.BookingTypeName);
                cmd.Parameters.AddWithValue("@BookingTypeDescription", bookingType.BookingTypeDescription ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update BookingType
        public void UpdateBookingType(BookingType bookingType)
        {
            string query = "UPDATE BookingType SET BookingTypeName = @BookingTypeName, BookingTypeDescription = @BookingTypeDescription WHERE BookingTypeId = @BookingTypeId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingTypeId", bookingType.BookingTypeId);
                cmd.Parameters.AddWithValue("@BookingTypeName", bookingType.BookingTypeName);
                cmd.Parameters.AddWithValue("@BookingTypeDescription", bookingType.BookingTypeDescription ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete BookingType
        public void DeleteBookingType(int bookingTypeId)
        {
            string query = "DELETE FROM BookingType WHERE BookingTypeId = @BookingTypeId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingTypeId", bookingTypeId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
