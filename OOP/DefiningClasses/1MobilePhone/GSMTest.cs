using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class GSMTest
    {
        public static GSM[] GSMTests()
        {
            GSM[] mobilePhone = new GSM[]
            {
               new GSM("One", "HTC", 850, "Person1", new Battery(880, 10, Battery.BatteryModel.LithiumLon), new Display(5, 65000)),
               new GSM("Desire", "HTC", 350, "Person2", new Battery(480, 6, Battery.BatteryModel.NiMH), new Display(3, 65000) ),
               new GSM("Samsung", "GS2", 450, "Person3", new Battery(980, 7, Battery.BatteryModel.LithiumPolymer), new Display(4, 165000) )
            };

           return mobilePhone;
        }

        GSM[] phones = GSMTests();

        public void GSMTesting()
        {
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
        

    }
}
