using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Display display;
        private Battery battery;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0.0d;
            this.owner = String.Empty;
            battery.Model = String.Empty;
            battery.HoursIdle = 0.0d;
            battery.HoursTalk = 0.0d;
            display.NumberOfColors = 0;
            display.Size = 0.0d;
        }

        public GSM(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = String.Empty;
            battery.Model = String.Empty;
            battery.HoursIdle = 0.0d;
            battery.HoursTalk = 0.0d;
        }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            battery.Model = String.Empty;
            battery.HoursIdle = 0.0d;
            battery.HoursTalk = 0.0d;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public override string ToString()
        {
            string result = String.Format("Model : {0} /nManufacturer: {1} /nPrice: {2} /nOwner: {3} /nBattery Model: {4}" +
                "Battery hours Idle: {5} /nBattery Hours Talk: {6} /nDisplay Size: {7} /nDisplay Colors: ",this.model,this.manufacturer,
                this.price,this.owner,battery.Model,battery.HoursIdle,battery.HoursTalk,display.Size,display.Size);

            return result;

        }
    }
}
