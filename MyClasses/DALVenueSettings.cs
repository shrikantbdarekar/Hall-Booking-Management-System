using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALVenueSettings
    {
        private string connectionString = MyConnectioString.Value;

        // Get All Venue Settings
        public List<VenueSetting> GetAllVenueSettings()
        {
            List<VenueSetting> venues = new List<VenueSetting>();
            string query = "SELECT * FROM VenueSetting";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    VenueSetting venue = new VenueSetting
                    {
                        VenueId = Convert.ToInt32(reader["VenueId"]),
                        VenueName = reader["VenueName"].ToString(),
                        VenueAddress = reader["VenueAddress"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        Email = reader["Email"].ToString(),
                        Website = reader["Website"].ToString()
                    };
                    venues.Add(venue);
                }
            }
            return venues;
        }

        // Get Venue Setting by ID
        public VenueSetting GetVenueSettingById(int venueId)
        {
            VenueSetting venue = null;
            string query = "SELECT * FROM VenueSetting WHERE VenueId = @VenueId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VenueId", venueId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    venue = new VenueSetting
                    {
                        VenueId = Convert.ToInt32(reader["VenueId"]),
                        VenueName = reader["VenueName"].ToString(),
                        VenueAddress = reader["VenueAddress"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        Email = reader["Email"].ToString(),
                        Website = reader["Website"].ToString()
                    };
                }
            }
            return venue;
        }

        // Insert Venue Setting
        public void InsertVenueSetting(VenueSetting venue)
        {
            string query = "INSERT INTO VenueSetting (VenueName, VenueAddress, MobileNumber, Email, Website) VALUES (@VenueName, @VenueAddress, @MobileNumber, @Email, @Website)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VenueName", venue.VenueName);
                cmd.Parameters.AddWithValue("@VenueAddress", venue.VenueAddress);
                cmd.Parameters.AddWithValue("@MobileNumber", venue.MobileNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", venue.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Website", venue.Website ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update Venue Setting
        public void UpdateVenueSetting(VenueSetting venue)
        {
            string query = "UPDATE VenueSetting SET VenueName = @VenueName, VenueAddress = @VenueAddress, MobileNumber = @MobileNumber, Email = @Email, Website = @Website WHERE VenueId = @VenueId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VenueId", venue.VenueId);
                cmd.Parameters.AddWithValue("@VenueName", venue.VenueName);
                cmd.Parameters.AddWithValue("@VenueAddress", venue.VenueAddress);
                cmd.Parameters.AddWithValue("@MobileNumber", venue.MobileNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", venue.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Website", venue.Website ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Venue Setting
        public void DeleteVenueSetting(int venueId)
        {
            string query = "DELETE FROM VenueSetting WHERE VenueId = @VenueId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VenueId", venueId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
