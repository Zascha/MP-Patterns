using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BehavioralPatterns.Tests")]
namespace BehavioralPatterns.ChainOfResponcibility
{
    internal class SimpleDemodulationHandler : DemodulationHandler
    {
        public override double Demodulate(double value)
        {
            if (value < 10000)
            {
                return value * 2;
            }

            if (Handler != null)
            {
                return Handler.Demodulate(value);
            }
            
            throw new Exception("Chain exception");
        }
    }
}
