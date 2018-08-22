using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFacebookApp.View
{
    internal class FacebookBirthdayAdapter
    {
        public string Birthday { get; set; }

        public DateTime ToDateTime()
        {
            customBirthdayString();
            Birthday = String.Format("{0}/{1}/2", Birthday.Substring(4, 2), Birthday.Substring(0, 2), Birthday.Substring(6, 2));

            return DateTime.Parse(Birthday);
        }

        private void customBirthdayString()
        {
            if (Birthday.Length <= 5)
            {
                Birthday += "/" + DateTime.Now.Year;
            }
        }
    }
}