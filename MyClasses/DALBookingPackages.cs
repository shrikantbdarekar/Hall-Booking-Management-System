using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALBookingPackages
    {
        private string connectionString = MyConnectioString.Value;

        // Get All Packages
        public List<BookingPackage> GetAllPackages()
        {
            List<BookingPackage> packages = new List<BookingPackage>();
            string query = "SELECT * FROM BookingPackages";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BookingPackage package = new BookingPackage
                    {
                        PackageId = Convert.ToInt32(reader["PackageId"]),
                        PackageName = reader["PackageName"].ToString(),
                        PackageAmount = Convert.ToDecimal(reader["PackageAmount"]),
                        PackageDescription = reader["PackageDescription"].ToString(),
                        HallId = Convert.ToInt32(reader["HallId"])
                    };
                    packages.Add(package);
                }
            }
            return packages;
        }

        // Get Package by ID
        public BookingPackage GetPackageById(int packageId)
        {
            BookingPackage package = null;
            string query = "SELECT * FROM BookingPackages WHERE PackageId = @PackageId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PackageId", packageId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    package = new BookingPackage
                    {
                        PackageId = Convert.ToInt32(reader["PackageId"]),
                        PackageName = reader["PackageName"].ToString(),
                        PackageAmount = Convert.ToDecimal(reader["PackageAmount"]),
                        PackageDescription = reader["PackageDescription"].ToString(),
                        HallId = Convert.ToInt32(reader["HallId"])
                    };
                }
            }
            return package;
        }

        // Insert Package
        public void InsertPackage(BookingPackage package)
        {
            string query = "INSERT INTO BookingPackages (PackageName, PackageAmount, PackageDescription, HallId) VALUES (@PackageName, @PackageAmount, @PackageDescription, @HallId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PackageName", package.PackageName);
                cmd.Parameters.AddWithValue("@PackageAmount", package.PackageAmount);
                cmd.Parameters.AddWithValue("@PackageDescription", package.PackageDescription ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@HallId", package.HallId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update Package
        public void UpdatePackage(BookingPackage package)
        {
            string query = "UPDATE BookingPackages SET PackageName = @PackageName, PackageAmount = @PackageAmount, PackageDescription = @PackageDescription, HallId=@HallId WHERE PackageId = @PackageId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PackageId", package.PackageId);
                cmd.Parameters.AddWithValue("@PackageName", package.PackageName);
                cmd.Parameters.AddWithValue("@PackageAmount", package.PackageAmount);
                cmd.Parameters.AddWithValue("@PackageDescription", package.PackageDescription ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@HallId", package.HallId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Package
        public void DeletePackage(int packageId)
        {
            string query = "DELETE FROM BookingPackages WHERE PackageId = @PackageId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PackageId", packageId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
