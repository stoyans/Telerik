using System;
using MobilePhone;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        public static void Main()
        {
            try
            {
                Display display = new Display(4, 16000000);
                Battery battery = new Battery(620, 8, Battery.BatteryModel.NiMH);
                GSM phone = new GSM("One", "HTC", 850, "Person", battery, display);

                GSMTest test = new GSMTest();
                Console.WriteLine("=============");
                test.GSMTesting();
                Console.WriteLine("=============");

                DateTime time = new DateTime();
                time = DateTime.Now;

                Calls[] call = new Calls[5];

                //making some phone calls                             
                for (int i = 0; i < 5; i++)
                {
                    time = time.AddDays(i);
                    string phoneNumber = "0888999999";
                    int duration = i + 100;
                    call[i] = new Calls(time, phoneNumber, duration);
                    phone.AddCall(call[i]);
                }

                Console.WriteLine();
                decimal pricePerMinute = 0.37m;

                //display call information
                phone.CallHistory();
                Console.WriteLine("=============");
                phone.TotalPriceOfCalls(pricePerMinute);
                Console.WriteLine("=============");
                phone.FindLongestCall();
                phone.TotalPriceOfCalls(pricePerMinute);
                Console.WriteLine("=============");
                phone.ClearCallHistory();
                phone.CallHistory();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

        }
    }
}
