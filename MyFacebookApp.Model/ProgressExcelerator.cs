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
            return excelerator(i_MainUser, i_TestUser, i_QuantityToIncreaseBy);
        }

        protected abstract int excelerator(User i_MainUser, User i_TestUser, int i_Increaser);       
    }

    internal class MutualPicturesExcelerator : ProgressExcelerator
    {
        protected override int excelerator(User i_MainUser, User i_TestUser, int i_IncreaseValue)
        {
            int exceleratedValue = 0;

            foreach(Photo photoOfMainUser in i_MainUser.PhotosTaggedIn)
            {
                if (i_TestUser.PhotosTaggedIn.Contains(photoOfMainUser))
                {
                    exceleratedValue += i_IncreaseValue;
                }
            }

            return exceleratedValue;
        }
    }
}
