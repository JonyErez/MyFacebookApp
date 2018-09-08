using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFacebookApp.Model
{
    abstract class ProgressExcelerator
    {
        public int IncreaseValue(User i_MainUser, User i_TestUser, int i_QuantityToIncreaseBy)
        {
            int valueToReturn = 0;

            foreach (Photo photoOfMainUser in i_MainUser.PhotosTaggedIn)
            {
                if (excelerateBy(photoOfMainUser, i_TestUser))
                {
                    valueToReturn += i_QuantityToIncreaseBy; 
                }
            }

            return valueToReturn;
        }

        protected abstract bool excelerateBy(Photo i_MainUserPhoto, User i_TestUser);       
    }

    internal class MutualPicturesExcelerator : ProgressExcelerator
    {
        protected override bool excelerateBy(Photo i_MainUserPhoto, User i_TestUser)
        {
            return i_TestUser.PhotosTaggedIn.Contains(i_MainUserPhoto);
        }
    }
}
