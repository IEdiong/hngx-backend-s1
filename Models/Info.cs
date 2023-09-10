using System.ComponentModel.DataAnnotations;

namespace HngX.StageOne.Models
{
    public class Info
    {
        [Display(Name = "slack_name")]
        public string? SlackName { get; set; }
        public string? CurrentDay { get; set; }
        public string? UtcTime { get; set; }
        public string? Track { get; set; }
        public string? GithubFileUrl { get; set; }
        public string? GithubRepoUrl { get; set; }
        public int StatusCode { get; set; }
    }
}