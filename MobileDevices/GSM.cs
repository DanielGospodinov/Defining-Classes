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
        }

        public GSM(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = String.Empty;
        }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
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
    }
}
