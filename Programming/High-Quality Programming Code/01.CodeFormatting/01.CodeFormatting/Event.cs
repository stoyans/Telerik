namespace Event
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;

            int comparebyDate = this.date.CompareTo(other.date);
            int comparebyTitle = this.title.CompareTo(other.title);
            int comparebyLocation = this.location.CompareTo(other.location);

            if (comparebyDate == 0)
            {
                if (comparebyTitle == 0)
                {
                    return comparebyLocation;
                }
                else
                {
                    return comparebyTitle;
                }
            }
            else
            {
                return comparebyDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}