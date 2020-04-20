using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevices
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] gsm = new GSM[3];

            gsm[0] = new GSM("S8","Samsung",900.0,"Ivan",new Battery(BatteryType.LiIon),new Display(5.8,"16M"));
            gsm[1] = new GSM("razr 2019", "Motorola", 1500.0, "Georgi",new Battery(BatteryType.LiIon), new Display(6.3, "16M"));
            gsm[2] = GSM.IPhone4S;

            for (int i = 0; i < gsm.Length; i++)
            {
                Console.WriteLine("GSM {0} :",i+1);
                Console.WriteLine(new string('-', 20));
                Console.WriteLine(gsm[i]);
                Console.WriteLine(new string('*',35));
            }
        }
    }
}
