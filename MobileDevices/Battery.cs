using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Battery
    {
        private BatteryType model;
        private double hoursIdle;
        private double hoursTalk;

        //Constructors
        public Battery()
        {
            this.model = 0;
            this.hoursIdle = 0.0D;
            this.hoursTalk = 0.0D;
        }

        public Battery(BatteryType model)
        {
            this.model = model;
            this.hoursIdle = 0.0d;
            this.hoursTalk = 0.0d;
        }

        public Battery(BatteryType model, double hoursIdle)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = 0.0d;
        }

        public Battery(BatteryType model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public BatteryType Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        //Properties
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

    // BatteryType enum
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
}
