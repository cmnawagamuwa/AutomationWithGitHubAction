using System;
using Newtonsoft.Json.Linq;

namespace TestAutomation
{
	public class Configurations
	{
		public string Username { get; set; }

        public string Password { get; set; }

        public string URL { get; set; }

        string GitHubUser { get; set; }

        public Configurations()
		{
            var settings = JObject.Parse(File.ReadAllText("appsettings.json"));
			LoadSeetings(settings);
        }

		void LoadSeetings(JObject settings)
		{
            GitHubUser = Environment.GetEnvironmentVariable("username");

            URL = settings[GitHubUser]?["url"]?.ToString() ?? string.Empty;
            Username = settings[GitHubUser]?["Username"]?.ToString() ?? string.Empty;
            Password = settings[GitHubUser]?["Password"]?.ToString() ?? string.Empty;            
        }
	}
}