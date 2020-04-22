using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevices
{
    class Battery
    {
        private BatteryType? model;
        private double? hoursIdle;
        private double? hoursTalk;

        //Constructors
        public Battery()
        {

        }

        public Battery(BatteryType model)
        {
            this.model = model;
        }

        public Battery(BatteryType model, double hoursIdle)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
        }

        public Battery(BatteryType model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public BatteryType? Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        //Properties
        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public double? HoursTalk
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
