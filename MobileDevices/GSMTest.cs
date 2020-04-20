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
            //////GSM
            
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

            //////Cals

            Call[] calls = new Call[5];
            calls[0] = new Call(DateTime.Now, "0876 444 162", 55);
            calls[1] = new Call(DateTime.Now, "0876 965 982", 958);
            calls[2] = new Call(DateTime.Now, "0896 444 365", 1023);
            calls[3] = new Call(DateTime.Now, "0886 365 162", 235);
            calls[4] = new Call(DateTime.Now, "0877 141 580", 25);

            for (int i = 0; i < calls.Length; i++)
            {
                GSM.AddCall(calls[i]);
            }

            GSM.PrintCalls();

            GSM.DeleteCalls(calls[2].DialedPhoneNumber);
            GSM.DeleteCalls(calls[3].DialedPhoneNumber);

            GSM.PrintCalls();

            GSM.ClearCalls();

            GSM.PrintCalls();
        }
    }
}
