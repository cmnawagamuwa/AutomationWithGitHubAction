using System;
using Newtonsoft.Json.Linq;

namespace TestAutomation
{
	public class Configurations
	{
		public string Username { get; set; }

        public string Password { get; set; }

        public string TestingUrl { get; set; }

        public Configurations()
		{
            var settings = JObject.Parse(File.ReadAllText("appsettings.json"));
			LoadSeetings(settings);
        }

		void LoadSeetings(JObject settings)
		{
            Username = settings["UserCredentials"]?["Username"]?.ToString() ?? string.Empty;
            Password = settings["UserCredentials"]?["Password"]?.ToString() ?? string.Empty;
            //wati-demo15.clare.ai
            TestingUrl = Environment.GetEnvironmentVariable("envURL");
        }
	}
}

