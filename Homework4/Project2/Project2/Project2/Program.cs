using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    public class AlarmEventArgs:EventArgs
    {
        public string soundalram = "Alarm!";
        

    }
    public class TickEventArgs:EventArgs
    {
        public string soundtick = "tick..";
    }
    public delegate void AlarmHandler(object sender,AlarmEventArgs a);//创建解决事件的委托
    public delegate void TickHandler(object sender,TickEventArgs t);
   

    class Clock
    {
        public int timetick;
        public bool power;
        public int Alarmtime;
        public event AlarmHandler alarmHandler;
        public event TickHandler tickHandler;



        public void clockSetTime(int time)
        {
            timetick = time;//设置始终的初始时间
        }

        public void setAlarm(int Settime)
        {
            Alarmtime = Settime;
           
        }
        public void clockOn()
        {
            power = true;
            
            while (power)
            {
                
                timetick++;//打开时钟   
                Thread.Sleep(1000);//每一秒运行一次循环
                TickEventArgs tick = new TickEventArgs();
                tickHandler(this, tick);
                if (timetick == Alarmtime)
                {
                    AlarmEventArgs alarm = new AlarmEventArgs();
                    alarmHandler(this, alarm);

                }
                if(timetick == 60)
                {
                    power = false;
                }

            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.alarmHandler += GoAlarm;
            clock.tickHandler += GoTick;
            
            clock.clockSetTime(0);
            clock.setAlarm(40);
            clock.clockOn();


        }
        static void GoAlarm(object sender, AlarmEventArgs a)
        {
            Console.WriteLine(a.soundalram);
        }
        static void GoTick(object sender, TickEventArgs t)
        {
            Console.WriteLine(t.soundtick);
        }
    }

}
