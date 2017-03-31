using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ClockEventsArgs : EventArgs
    {
        public ClockEventsArgs(DateTime dataTime)
        {
            CurrentDataTime = dataTime;
        }
        public DateTime CurrentDataTime { get;  set; }
    }

}
