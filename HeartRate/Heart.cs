using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRate
{
    class Heart
    {
        Clock clock;
        public Heart(){
            clock = new Clock();
            
        }
        private const double typicalRate = 60.0;

        private double currentRate=typicalRate;
        private double lastRate;

        public double Hit() {
            
            lastRate = currentRate;
            currentRate = 1/clock.getPeroid();
                
            return (int)currentRate;
        }

    }
}
