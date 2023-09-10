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
            DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;
            var data = new Info
            {
                SlackName = slack_name,
                CurrentDay = DateTime.UtcNow.DayOfWeek.ToString(),
                UtcTime = currentUtcTime.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                Track = track,
                GithubFileUrl = "https://github.com/IEdiong/hngx-backend-s1/blob/main/Controllers/InfoController.cs",
                GithubRepoUrl = "https://github.com/IEdiong/hngx-backend-s1",
                StatusCode = 200
            };
            return Ok(data);
        }
    }
}