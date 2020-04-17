using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;

        public Battery()
        {
            this.model = String.Empty;
            this.hoursIdle = 0.0D;
            this.hoursTalk = 0.0D;
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = 0.0d;
            this.hoursTalk = 0.0d;
        }

        public Battery(string model, double hoursIdle)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = 0.0d;
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
    }
}
