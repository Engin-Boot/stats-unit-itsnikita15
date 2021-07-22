using System;

namespace Statistics
{

    public class LEDAlert : IAlerter
    {
        public bool ledGlows;
        public LEDAlert()
        {
            this.ledGlows = false;
        }

        public void alert()
        {
            this.ledGlows = true;
        }

    }
}
