using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALPayments
    {
        private string connectionString = MyConnectioString.Value;

        // Get All Payments
        public List<Payment> GetAllPayments()
        {
            List<Payment> payments = new List<Payment>();
            string query = "SELECT * FROM Payments";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Payment payment = new Payment
                    {
                        PaymentId = Convert.ToInt32(reader["PaymentId"]),
                        PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                        EventBookingId = Convert.ToInt32(reader["EventBookingId"]),
                        DueAmount = Convert.ToDecimal(reader["DueAmount"]),
                        PaymentAmount = Convert.ToDecimal(reader["PaymentAmount"]),
                        BalanceAmount = Convert.ToDecimal(reader["BalanceAmount"]),
                        Remark = reader["Remark"].ToString()
                    };
                    payments.Add(payment);
                }
            }
            return payments;
        }

        // Get Payment by ID
        public Payment GetPaymentById(int paymentId)
        {
            Payment payment = null;
            string query = "SELECT * FROM Payments WHERE PaymentId = @PaymentId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentId", paymentId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    payment = new Payment
                    {
                        PaymentId = Convert.ToInt32(reader["PaymentId"]),
                        PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                        EventBookingId = Convert.ToInt32(reader["EventBookingId"]),
                        DueAmount = Convert.ToDecimal(reader["DueAmount"]),
                        PaymentAmount = Convert.ToDecimal(reader["PaymentAmount"]),
                        BalanceAmount = Convert.ToDecimal(reader["BalanceAmount"]),
                        Remark = reader["Remark"].ToString()
                    };
                }
            }
            return payment;
        }

        // Insert Payment
        public void InsertPayment(Payment payment)
        {
            string query = "INSERT INTO Payments (PaymentDate, EventBookingId, DueAmount, PaymentAmount, BalanceAmount, Remark) VALUES (@PaymentDate, @EventBookingId, @DueAmount, @PaymentAmount, @BalanceAmount, @Remark)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                cmd.Parameters.AddWithValue("@EventBookingId", payment.EventBookingId);
                cmd.Parameters.AddWithValue("@DueAmount", payment.DueAmount);
                cmd.Parameters.AddWithValue("@PaymentAmount", payment.PaymentAmount);
                cmd.Parameters.AddWithValue("@BalanceAmount", payment.BalanceAmount);
                cmd.Parameters.AddWithValue("@Remark", payment.Remark ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update Payment
        public void UpdatePayment(Payment payment)
        {
            string query = "UPDATE Payments SET PaymentDate = @PaymentDate, EventBookingId = @EventBookingId, DueAmount = @DueAmount, PaymentAmount = @PaymentAmount, BalanceAmount = @BalanceAmount, Remark = @Remark WHERE PaymentId = @PaymentId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentId", payment.PaymentId);
                cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                cmd.Parameters.AddWithValue("@EventBookingId", payment.EventBookingId);
                cmd.Parameters.AddWithValue("@DueAmount", payment.DueAmount);
                cmd.Parameters.AddWithValue("@PaymentAmount", payment.PaymentAmount);
                cmd.Parameters.AddWithValue("@BalanceAmount", payment.BalanceAmount);
                cmd.Parameters.AddWithValue("@Remark", payment.Remark ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Payment
        public void DeletePayment(int paymentId)
        {
            string query = "DELETE FROM Payments WHERE PaymentId = @PaymentId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentId", paymentId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get Collection Report
        public List<CollectionReport> GetCollectionReport()
        {
            List<CollectionReport> collectionReportList = new List<CollectionReport>();

            string query = "Select P.PaymentId,P.PaymentDate,B.EventName,C.CustomerName,P.Remark,P.PaymentAmount from Payments P " +
                "Left Outer Join EventBookings B On P.EventBookingId = B.EventBookingId " +
                "Left Outer Join Customers C On B.CustomerId = C.CustomerId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CollectionReport collectionReport = new CollectionReport
                    {
                        PaymentId = Convert.ToInt32(reader["PaymentId"]),
                        PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                        EventName = reader["EventName"].ToString(),
                        CustomerName = reader["CustomerName"].ToString(),
                        Remark = reader["Remark"].ToString(),
                        PaymentAmount = Convert.ToDecimal(reader["PaymentAmount"])
                    };
                    collectionReportList.Add(collectionReport);
                }
            }
            return collectionReportList;
        }


    }
}
