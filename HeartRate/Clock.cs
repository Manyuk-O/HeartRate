using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRate
{
    class Clock
    {
        private System.Diagnostics.Stopwatch stopwach = new System.Diagnostics.Stopwatch();
        public void Start() {
            stopwach.Reset();
            stopwach.Start();
        }
        public double getPeroid() {
            stopwach.Stop();
            double temp = stopwach.Elapsed.TotalMinutes;
            if (temp < 0.001 || temp > 0.5)
                temp = 0.02;
            Start();
            return temp;
        } 
    }
}
