using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HallBookingManagementSystem.MyClasses
{
    public class DALEventTypes
    {
        private string connectionString = MyConnectioString.Value;

        // Get All EventTypes
        public List<EventType> GetAllEventTypes()
        {
            List<EventType> eventTypes = new List<EventType>();
            string query = "SELECT * FROM EventType";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EventType eventType = new EventType
                    {
                        EventTypeId = Convert.ToInt32(reader["EventTypeId"]),
                        EventTypeName = reader["EventTypeName"].ToString(),
                        EventTypeDescription = reader["EventTypeDescription"].ToString()
                    };
                    eventTypes.Add(eventType);
                }
            }
            return eventTypes;
        }

        // Get EventType by ID
        public EventType GetEventTypeById(int eventTypeId)
        {
            EventType eventType = null;
            string query = "SELECT * FROM EventType WHERE EventTypeId = @EventTypeId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventTypeId", eventTypeId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    eventType = new EventType
                    {
                        EventTypeId = Convert.ToInt32(reader["EventTypeId"]),
                        EventTypeName = reader["EventTypeName"].ToString(),
                        EventTypeDescription = reader["EventTypeDescription"].ToString()
                    };
                }
            }
            return eventType;
        }

        // Insert EventType
        public void InsertEventType(EventType eventType)
        {
            string query = "INSERT INTO EventType (EventTypeName, EventTypeDescription) VALUES (@EventTypeName, @EventTypeDescription)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventTypeName", eventType.EventTypeName);
                cmd.Parameters.AddWithValue("@EventTypeDescription", eventType.EventTypeDescription ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update EventType
        public void UpdateEventType(EventType eventType)
        {
            string query = "UPDATE EventType SET EventTypeName = @EventTypeName, EventTypeDescription = @EventTypeDescription WHERE EventTypeId = @EventTypeId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventTypeId", eventType.EventTypeId);
                cmd.Parameters.AddWithValue("@EventTypeName", eventType.EventTypeName);
                cmd.Parameters.AddWithValue("@EventTypeDescription", eventType.EventTypeDescription ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete EventType
        public void DeleteEventType(int eventTypeId)
        {
            string query = "DELETE FROM EventType WHERE EventTypeId = @EventTypeId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventTypeId", eventTypeId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
