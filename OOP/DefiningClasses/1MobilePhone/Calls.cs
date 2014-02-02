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
                this.duration = value;
            }
        }

    }
}

