using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevices
{
    class Call
    {
        //Fields
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private long duration;

        private const double pricePerMinute = 0.05;

        // Constructors

        public Call (string dialedPhoneNumber)
        {
            this.dialedPhoneNumber = dialedPhoneNumber;
        }
        public Call(DateTime dateAndTime, string dialedPhoneNumber, long duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }

        //Properties
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public long Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public double GetPrice()
        {
            double timeInMinutes = (double)this.Duration / 60;
            double secLowerThenMin = (double)((int)timeInMinutes - (double)timeInMinutes);

            if (secLowerThenMin == 0)
            {
                return timeInMinutes * pricePerMinute;
            }
            else
            {
                return ((int)timeInMinutes * pricePerMinute) + pricePerMinute;
            }
        }
    }
}
