using System;
using MobilePhone;

namespace MobilePhone
{
	class MainClass
	{
		public static void Main ()
		{
			int sizeDisplay = 4;
			int numberOfColors = 16000000;
			Display display = new Display (sizeDisplay, numberOfColors);
			Battery battery = new Battery (620, 8, Battery.BatteryModel.NiMH);
			GSM phone = new GSM ("One", "HTC", 850, "Person", battery, display);

            GSMTest test = new GSMTest();
            test.GSMTesting();

			DateTime time = new DateTime();
			time = DateTime.Now;
			
			Calls[] call = new Calls[5];
			                             
			for (int i = 0; i < 5; i++) 
			{
				time = time.AddDays(i);
				string phoneNumber = "089999999";
				int duration = i + 100;
				call[i] = new Calls(time, phoneNumber, duration);
				phone.AddCall(call[i]);
			}
			
			//Console.WriteLine (phone.ToString ());
			Console.WriteLine ();
			phone.TotalPriceOfCalls();
			
			phone.CallHistory();
			
			phone.RemoveCall(2);
			Console.WriteLine (new string('=', 20));
			phone.CallHistory();
			phone.ClearCallHistory();
			phone.CallHistory();
			

		}
	}
}
