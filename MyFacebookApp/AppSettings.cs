using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MyFacebookApp
{
	public class AppSettings
	{
		private string m_LastAccessToken = String.Empty;
		private Point m_Location = new Point(10, 10);
		private bool m_RememberUser = false;

		private AppSettings()
		{

		}

		public string LastAccessToken
		{
			get { return m_LastAccessToken; }
			set { m_LastAccessToken = value; }
		}

		public Point Location
		{
			get { return m_Location; }
			set { m_Location = value; }
		}

		public bool RememberUser
		{
			get { return m_RememberUser; }
			set { m_RememberUser = value; }
		}

		public static AppSettings LoadAppSettings()
		{
			AppSettings appSettings = new AppSettings();
			string currentLocation = System.Environment.CurrentDirectory;

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
			string currentLocation = System.Environment.CurrentDirectory;

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
