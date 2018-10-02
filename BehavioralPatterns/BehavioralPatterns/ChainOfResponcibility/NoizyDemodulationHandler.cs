using System;

namespace BehavioralPatterns.ChainOfResponcibility
{
    internal class NoizyDemodulationHandler : DemodulationHandler
    {
        public override double Demodulate(double value)
        {
            if(value >= 10000)
            {
                return Math.Round(value * 2, 2);
            }

            if (Handler != null)
            {
                return Handler.Demodulate(value);
            }

            throw new Exception("Chain exception");
        }
    }
}
