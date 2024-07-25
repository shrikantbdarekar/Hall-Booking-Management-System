using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALCustomers
    {
        private string connectionString = MyConnectioString.Value;

        // Get All Customers
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT * FROM Customers";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        CustomerName = reader["CustomerName"].ToString(),
                        CustomerAddress = reader["CustomerAddress"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        Email = reader["Email"].ToString(),
                        Remark = reader["Remark"].ToString()
                    };
                    customers.Add(customer);
                }
            }
            return customers;
        }

        // Get Customer by ID
        public Customer GetCustomerById(int customerId)
        {
            Customer customer = null;
            string query = "SELECT * FROM Customers WHERE CustomerId = @CustomerId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer
                    {
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        CustomerName = reader["CustomerName"].ToString(),
                        CustomerAddress = reader["CustomerAddress"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        Email = reader["Email"].ToString(),
                        Remark = reader["Remark"].ToString()
                    };
                }
            }
            return customer;
        }

        // Insert Customer
        public void InsertCustomer(Customer customer)
        {
            string query = "INSERT INTO Customers (CustomerName, CustomerAddress, MobileNumber, Email, Remark) VALUES (@CustomerName, @CustomerAddress, @MobileNumber, @Email, @Remark)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                cmd.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
                cmd.Parameters.AddWithValue("@MobileNumber", customer.MobileNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", customer.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Remark", customer.Remark ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update Customer
        public void UpdateCustomer(Customer customer)
        {
            string query = "UPDATE Customers SET CustomerName = @CustomerName, CustomerAddress = @CustomerAddress, MobileNumber = @MobileNumber, Email = @Email, Remark = @Remark WHERE CustomerId = @CustomerId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                cmd.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
                cmd.Parameters.AddWithValue("@MobileNumber", customer.MobileNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", customer.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Remark", customer.Remark ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Customer
        public void DeleteCustomer(int customerId)
        {
            string query = "DELETE FROM Customers WHERE CustomerId = @CustomerId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
