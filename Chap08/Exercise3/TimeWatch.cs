using System;

namespace Exercise3
{
    class TimeWatch
    {
        private DateTime _start;

        public void Start()
        {
            _start = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            return DateTime.Now - _start;
        }
    }
}
