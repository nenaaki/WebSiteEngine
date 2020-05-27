using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteEngine.Shared;

namespace WebSiteEngine.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextileDocumentController : ControllerBase
    {
        [HttpGet("{localPath}")]
        public IActionResult Get(string localPath)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "local", localPath);

            return Ok(new TextileDocument { Body = System.IO.File.ReadAllText(path) });
        }
    }
}
