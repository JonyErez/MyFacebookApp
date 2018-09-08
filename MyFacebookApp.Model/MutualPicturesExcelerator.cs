using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.Model
{
	internal class MutualPicturesExcelerator : ProgressExcelerator
	{
		protected override bool excelerateBy(Photo i_MainUserPhoto, User i_TestUser)
		{
			return i_TestUser.PhotosTaggedIn.Contains(i_MainUserPhoto);
		}
	}
}
