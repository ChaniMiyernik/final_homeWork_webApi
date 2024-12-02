//using Microsoft.EntityFrameworkCore;
//using System.Data;
//using Microsoft.Data.SqlClient;

using System.Data;
using Microsoft.Data.SqlClient;

namespace lesson3.Dl
{
    public class AttachmentRepository : IAttachmentRepository
    {
        string? Cnn;
        public AttachmentRepository(IConfiguration configuration)
        {
            Cnn = configuration.GetConnectionString("DefaultConnection");
        }
        public DataTable AddAttachment(string name, string url, string description)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Cnn))
            {
                using (SqlCommand command = new SqlCommand("Add_Attachment", connection))
                {
                    connection.Open();
                    command.CommandText = "Add_Attachment";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@url", url);
                    command.Parameters.AddWithValue("@description", description);
                    int rowsAffact = command.ExecuteNonQuery();
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public DataTable GetTasksByProjectId(int projectId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Cnn))
            {
                using (SqlCommand command = new SqlCommand("GetTaskByProjectId", connection))
                {
                    //commandtype
                    command.CommandText = "GetTaskByProjectId";
                    command.CommandType = CommandType.StoredProcedure;

                    //paramters
                    SqlParameter sqlParameter = new SqlParameter("@ProjectId", projectId);
                    command.Parameters.Add(sqlParameter);
                    connection.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
