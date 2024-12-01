using lesson3.Bl;
using lesson3.Dl;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Attachments : ControllerBase
    {
        private readonly IAttachmentRepository _attachmentRepository;
        public Attachments(IAttachmentRepository attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
        }
        [HttpPost]
        public IActionResult AddAttachment([FromQuery] string name, string url, string description)
        {
            DataTable dt = _attachmentRepository.AddAttachment(name, url, description);
            return Ok("dt");
        }
        [HttpGet("{projectId}")]
        public IActionResult GetTasksByProjectId(int projectId)
        {
            DataTable dt = _attachmentRepository.GetTasksByProjectId(projectId);
            if (dt != null)
                return Ok("well done");
            return Ok("oooopppppppssssssss");

        }
    }
    
}
