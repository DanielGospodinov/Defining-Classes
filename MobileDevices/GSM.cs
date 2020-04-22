using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevices
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Display display;
        private Battery battery;

        private static readonly GSM iPhone4S = new GSM("iPhone 4S", "Apple", 1200.00, "Mimi",new Battery(BatteryType.NiMH), new Display(3.5, "16M"));

        //Constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            display = new Display();
            battery = new Battery();
        }

        public GSM(string model, string manufacturer, double price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
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

        public double? Price
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

        private static List<Call> CallHistory = new List<Call>();

        //override ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(String.Format("Model : {0}\n", this.Model));
            result.Append(String.Format("Manufacturer: {0}\n",this.Manufacturer));
            if (this.Price != null) result.Append(String.Format("Price: {0} lv\n", this.Price));
            if (this.Owner != null) result.Append(String.Format("Owner: {0}\n", this.Owner));
            if (battery.Model != null) result.Append(String.Format("Battery Model: {0}\n", battery.Model));
            if (display.Size != null) result.Append(String.Format("Display Size: {0}\"\n", display.Size));
            if (display.NumberOfColors != null) result.Append(String.Format("Colors: {0}\"\n", display.NumberOfColors));

            return result.ToString();

        }

        // Call methods

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCalls (string dialedPhoneNumber)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].DialedPhoneNumber.Equals(dialedPhoneNumber))
                {
                    CallHistory.Remove(CallHistory[i]);

                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Call number {0} from {1} is deleted.", i+1, dialedPhoneNumber);
                    Console.WriteLine(new string('-', 50));
                }
            }
        }

        public void ClearCalls()
        {
            CallHistory.Clear();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Call History is deleted!");
            Console.WriteLine(new string('-', 50));
        }

        public void GetTotalPrice()
        {
            double result = 0;

            for (int i = 0; i < CallHistory.Count; i++)
            {
                result += CallHistory[i].GetPrice();
            }
            Console.WriteLine("Total Price : {0:F2}",result);
        }
        public void PrintCalls()
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Console.WriteLine("Call number {0}" , i+1);
                Console.WriteLine("Number : {0}\n" + "Time : {1}\n" +"Duration : {2}\n" + "Price : {3:F2} lv",
                    CallHistory[i].DialedPhoneNumber, CallHistory[i].DateAndTime , TimeSpan.FromSeconds(CallHistory[i].Duration), CallHistory[i].GetPrice());
                Console.WriteLine(new string('*',30));
            }
        }
    }
}
