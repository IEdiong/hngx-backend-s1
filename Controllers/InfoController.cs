using HngX.StageOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace HngX.StageOne.Controllers
{
    [ApiController]
    [Route("/api")]
    public class InfoController : ControllerBase
    {

        // GET: /api?slack_name=example_name&track=backend
        [HttpGet]
        public IActionResult GetInfo(string slack_name, string track)
        {
            var data = new Info
            {
                SlackName = slack_name,
                CurrentDay = DateTime.Now.DayOfWeek.ToString(),
                UtcTime = DateTime.UtcNow,
                Track = track,
                GithubFileUrl = "https://github.com/username/repo/blob/main/file_name.ext",
                GithubRepoUrl = "https://github.com/IEdiong/hngx-backend-s1",
                StatusCode = 200
            };
            return Ok(data);
        }
    }
}

