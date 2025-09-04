using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___3
{
    class Clock
    {
        private int hour = 0;
        private int minute = 0;
        private int second = 0;

        public Clock(int hour,int minute, int second){
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void displayTime()
        {
            Console.WriteLine("time : "+hour +":" + minute + ":" + second);
        }

        public void incrementTime()
        {
            second += 1;
            if(second > 60)
            {
                second = 0;
                minute += 1;
            }else if(minute > 60)
            {
                minute = 0;
                hour += 1;
            }else if(hour > 24)
            {
                hour = 0;
            }
        }
        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return minute;
        }

        public int getSecond()
        {
            return second;
        }
    }
    internal class T2
    {
        public static void t2()
        {

            Clock clock = new Clock(12, 00, 00);
            clock.incrementTime();
            clock.displayTime();
        }
        

    }
}
