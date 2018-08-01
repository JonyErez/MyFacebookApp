using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace MyFacebookApp
{
	public class AppSettings
	{
		private AppSettings()
		{
		}

		public string LastAccessToken { get; set; } = string.Empty;

		public Point Location { get; set; } = new Point(10, 10);

		public bool RememberUser { get; set; }

		public static AppSettings LoadAppSettings()
		{
			AppSettings appSettings = new AppSettings();
			string currentLocation = Environment.CurrentDirectory;
			currentLocation += "\\appSettings.xml";
			if (File.Exists(currentLocation) && new FileInfo(currentLocation).Length > 0)
			{
				using (Stream stream = new FileStream(currentLocation, FileMode.Open))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
					appSettings = serializer.Deserialize(stream) as AppSettings;
				}
			}

			return appSettings;
		}

		public void SaveAppSettings()
		{
			string currentLocation = Environment.CurrentDirectory;
			currentLocation += "\\appSettings.xml";
			FileMode fileMode = File.Exists(currentLocation) ? FileMode.Truncate : FileMode.Create;
			using (Stream stream = new FileStream(currentLocation, fileMode))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
				serializer.Serialize(stream, this);
			}
		}
	}
}