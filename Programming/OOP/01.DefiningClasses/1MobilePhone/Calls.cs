using System;

namespace MobilePhone
{
    public class Calls
    {
        private DateTime dateTime;
        private string dialedPhone;
        private int duration;

        public Calls(DateTime date, string dialedPhone, int duration)
        {
            this.Date = date;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            set
            {
                if (value.Length < 6 || value == null)
                {
                    throw new ArgumentOutOfRangeException("Phone number is invalid!");
                }
                this.dialedPhone = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Duration of the call can't be negative!");
                }
                this.duration = value;
            }
        }

    }
}

