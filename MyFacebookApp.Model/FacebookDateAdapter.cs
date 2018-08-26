using System;

namespace MyFacebookApp.Model
{
    public class FacebookDateAdapter
    {
        public string Date { get; set; }

		private const int k_PartialDate = 5;

		public DateTime ToDateTime()
        {
            customDateString();
            Date = string.Format("{0}/{1}/{2}", Date.Substring(3, 2), Date.Substring(0, 2), Date.Substring(6));

            return DateTime.Parse(Date);
        }

        private void customDateString()
        {
            if (Date.Length <= k_PartialDate)
            {
                Date += "/" + DateTime.Now.Year;
            }
        }
    }
}