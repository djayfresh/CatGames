using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace MouseCatch.Helper.Time
{
    public class Clock
    {
        private long LastTick { get; set; }
        private long ThisTick { get; set; }
        private long DeltaTick { get; set; }
        public double DT { get { return DeltaTime(); } }

        private Timer timer;

        public Clock()
        {
        }

        private void Tick(object state)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            LastTick = DateTime.Now.Ticks;
            ThisTick = DateTime.Now.Ticks;
        }
        
        public void Tick()
        {
            LastTick = ThisTick;
            ThisTick = DateTime.Now.Ticks;
        }

        private double DeltaTime()
        {
            DeltaTick = ThisTick - LastTick;
            int millisecond = new DateTime(DeltaTick).Millisecond;
            return millisecond / 1000.0d;
        }
    }
}
