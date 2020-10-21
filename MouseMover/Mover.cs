using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using WindowsInput;

namespace MouseMover
{
    public class Mover
    {

        private Timer _timer;

        public Mover()
        {
            _timer = new Timer();
            _timer.Interval = 3000;
            _timer.Elapsed += _timer_Elapsed;
        }

        public void Enable()
        {
            _timer.Start();
        }

        public void Disable()
        {
            _timer.Stop();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var inSim = new InputSimulator();
            inSim.Mouse.MoveMouseBy(0, 0);
        }
    }
}
