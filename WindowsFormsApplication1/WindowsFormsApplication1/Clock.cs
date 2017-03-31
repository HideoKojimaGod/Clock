using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Clock
    {
        Timer timer = new Timer();
        public DateTime Time {get; private set;}
        public event EventHandler<ClockEventsArgs> Tick;
        public Clock()
        {
            Time = DateTime.Now;
            timer.Tick += TickHandler;
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            
        }
        private void TickHandler(object sender, EventArgs e)
        {
            Time = DateTime.Now;
            var clockEvent = new ClockEventsArgs(Time);
            OnTick(clockEvent);
            //Console.WriteLine(c.CurrentDataTime.ToLongTimeString);
        }

        private void OnTick(ClockEventsArgs e)
        {
            var handler = this.Tick;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        //public void Start()
        //{
        //    timer.Start();
        //    clockTime = DateTime.Now;
            
        //}
    }
}
