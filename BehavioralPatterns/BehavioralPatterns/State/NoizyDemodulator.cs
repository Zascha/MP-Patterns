using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BehavioralPatterns.Tests")]
namespace BehavioralPatterns.State
{
    internal class NoizyDemodulator : IDemodulator
    {
        public double Demodulate(Demodulation demodulation)
        {
            if(demodulation.Value >= 10000)
            {
                demodulation.Demodulator = new SimpleDemodulator();
                demodulation.Value = demodulation.Demodulator.Demodulate(demodulation);
                return demodulation.Value;
            }

            demodulation.Value = Math.Round(demodulation.Value * 2, 2);
            return demodulation.Value;
        }
    }
}
