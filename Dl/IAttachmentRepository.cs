using Microsoft.AspNetCore.Routing.Constraints;
using System.Data;

namespace lesson3.Dl
{
    public interface IAttachmentRepository
    {
        DataTable AddAttachment(string name, string url, string description);
        DataTable GetTasksByProjectId(int projectId);
    }
}