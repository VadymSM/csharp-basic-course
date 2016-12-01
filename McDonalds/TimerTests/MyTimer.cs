using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerTests
{
    class MyTimer
    {
        // Установить таймер на 1 минуту, каждые 5 сек. выводить в консоль текущее время. 
        // После 1 мин. заверишть работу.
        static int n = 0;

        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.Write(DateTime.Now);
            n++;
        }

        static void Main(string[] args)
        {
            Timer tmr = new Timer();
            tmr.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            tmr.Interval = 5000;
            tmr.Enabled = true;
            while (n != 12) ;

        }
        
    }
}
