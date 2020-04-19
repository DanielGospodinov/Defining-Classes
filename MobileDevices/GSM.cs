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

        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 1200.00, "Mimi",new Battery(BatteryType.NiMH), new Display(3.5, "16M"));

        //Constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0.0d;
            this.owner = String.Empty;
        }

        public GSM(string model, string manufacturer, double price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = String.Empty;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        //Properties
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
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        //override ToString()
        public override string ToString()
        {
            string result = String.Format("Model : {0}\n" + "Manufacturer: {1}\n" + "Price: {2} lv\n" + "Owner: {3}\n" +
                "Battery Model: {4}\n" + "Display size: {5}\"\n" + "Number of collors: {6}",this.model,this.manufacturer,
                this.price,this.owner,battery.Model,display.Size,display.NumberOfColors);

            return result;

        }
    }
}
