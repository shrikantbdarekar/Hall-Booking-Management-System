using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALUsers
    {
        private string connectionString = MyConnectioString.Value;

        // Get All Users
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM Users";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        UserName = reader["UserName"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        UserRole = reader["UserRole"].ToString()
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        // Get User by ID
        public User GetUserById(int userId)
        {
            User user = null;
            string query = "SELECT * FROM Users WHERE UserId = @UserId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        UserName = reader["UserName"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        UserRole = reader["UserRole"].ToString()
                    };
                }
            }
            return user;
        }

        // Insert User
        public void InsertUser(User user)
        {
            string query = "INSERT INTO Users (UserName, PasswordHash, UserRole) VALUES (@UserName, @PasswordHash, @UserRole)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@UserRole", user.UserRole);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update User
        public void UpdateUser(User user)
        {
            string query = "UPDATE Users SET UserName = @UserName, PasswordHash = @PasswordHash, UserRole = @UserRole WHERE UserId = @UserId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", user.UserId);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@UserRole", user.UserRole);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("DELETE FROM Users WHERE UserId = @UserId", connection);
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
