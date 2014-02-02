using System;
using System.Collections.Generic;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;
        internal static GSM IPhone4S = new GSM("IPhone4S", "Apple", 1000, "Somebody");
        List<Calls> callsTotal = new List<Calls>();


        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }
        public GSM(string model, string manufacturer, int price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException();
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException();
                }

                this.manufacturer = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException();
                }

                this.owner = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public void AddCall(Calls call)
        {
            callsTotal.Add(call);
        }

        public void RemoveCall(int callID)
        {
            callsTotal.RemoveAt(callID);
        }

        public void ClearCallHistory()
        {
            callsTotal.Clear();
            Console.WriteLine("Call history was deleted!");
        }

        public void TotalPriceOfCalls(decimal pricePerMinute)
        {
            decimal totalPrice = 0;

            for (int i = 0; i < callsTotal.Count; i++)
            {
                totalPrice += pricePerMinute * (decimal)Math.Round((double)(callsTotal[i].Duration) / 60);
            }

            Console.WriteLine("Total price of the calls is {0:F2}", totalPrice);
        }

        public void CallHistory()
        {
            if (callsTotal.Count == 0)
            {
                Console.WriteLine("No records in call history!");
            }
            else
            {
                for (int i = 0; i < callsTotal.Count; i++)
                {
                    Console.WriteLine("Call{0}:\nDateAndTime: {1}\nPhone: {2}\nDuration: {3}",
                    i, callsTotal[i].Date, callsTotal[i].DialedPhone, callsTotal[i].Duration);
                }
            }
        }

        public void FindLongestCall()
        {
            int longestCallID = 0;
            int longestCall = 0;

            for (int i = 0; i < callsTotal.Count; i++)
            {
                if (longestCall < callsTotal[i].Duration)
                {
                    longestCallID = i;
                    longestCall = callsTotal[i].Duration;

                }
            }
            RemoveCall(longestCallID);
            Console.WriteLine("The longest call with duration {0} was removed!", longestCall);
        }

        public override string ToString()
        {
            string completeInfo = string.Format("Model of the phone is: {0} {1}. It costs {2} and belogns to {3}.", this.manufacturer,
            this.model, this.price, this.owner);

            if (this.battery != null)
            {
                completeInfo += "\n" + battery.BatteryInfo();
            }
            if (this.battery != null)
            {
                completeInfo += "\n" + display.ToString();
            }
            return completeInfo;
        }

    }
}

