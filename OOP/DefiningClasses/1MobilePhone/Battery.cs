using System;

namespace MobilePhone
{
    public class Battery
    {

        private int idleHours;
        private int talkHours;
        private BatteryModel batteryModel;

        public enum BatteryModel
        {
            NiMH, NiCd, LithiumPolymer, LithiumLon
        }

        public Battery(int IdleHours, int TalkHours, BatteryModel modelBattery)
        {
            this.IdleHours = IdleHours;
            this.TalkHours = TalkHours;
            this.batteryModel = modelBattery;
        }

        public int IdleHours
        {
            get
            {
                return this.idleHours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.idleHours = value;
            }
        }

        public int TalkHours
        {
            get
            {
                return this.talkHours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.talkHours = value;
            }
        }

        public string BatteryInfo()
        {
            return string.Format("Battery type is: {0}, idlehours are {1}, talk houres are {2}",
            this.batteryModel, this.idleHours, this.talkHours);
        }
    }
}

