using System;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.Model
{
	public class PhotoSearchStrategy
	{
		public Func<Photo, bool> Strategy { get; set; }

		public string Name { get; set; }
	}
}
