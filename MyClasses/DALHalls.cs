using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALHalls
    {
        private string connectionString = MyConnectioString.Value;

        // Get All Halls
        public List<Hall> GetAllHalls()
        {
            List<Hall> halls = new List<Hall>();
            string query = "SELECT * FROM Halls";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Hall hall = new Hall
                    {
                        HallId = Convert.ToInt32(reader["HallId"]),
                        HallName = reader["HallName"].ToString(),
                        HallCapacity = Convert.ToInt32(reader["HallCapacity"]),
                        HallDescription = reader["HallDescription"].ToString()
                    };
                    halls.Add(hall);
                }
            }
            return halls;
        }

        // Get Hall by ID
        public Hall GetHallById(int hallId)
        {
            Hall hall = null;
            string query = "SELECT * FROM Halls WHERE HallId = @HallId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallId", hallId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hall = new Hall
                    {
                        HallId = Convert.ToInt32(reader["HallId"]),
                        HallName = reader["HallName"].ToString(),
                        HallCapacity = Convert.ToInt32(reader["HallCapacity"]),
                        HallDescription = reader["HallDescription"].ToString()
                    };
                }
            }
            return hall;
        }

        // Insert Hall
        public void InsertHall(Hall hall)
        {
            string query = "INSERT INTO Halls (HallName, HallCapacity, HallDescription) VALUES (@HallName, @HallCapacity, @HallDescription)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallName", hall.HallName);
                cmd.Parameters.AddWithValue("@HallCapacity", hall.HallCapacity);
                cmd.Parameters.AddWithValue("@HallDescription", hall.HallDescription);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update Hall
        public void UpdateHall(Hall hall)
        {
            string query = "UPDATE Halls SET HallName = @HallName, HallCapacity = @HallCapacity, HallDescription = @HallDescription WHERE HallId = @HallId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallId", hall.HallId);
                cmd.Parameters.AddWithValue("@HallName", hall.HallName);
                cmd.Parameters.AddWithValue("@HallCapacity", hall.HallCapacity);
                cmd.Parameters.AddWithValue("@HallDescription", hall.HallDescription);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Hall
        public void DeleteHall(int hallId)
        {
            string query = "DELETE FROM Halls WHERE HallId = @HallId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HallId", hallId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
