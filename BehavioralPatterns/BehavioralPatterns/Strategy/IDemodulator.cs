using System.Collections.Generic;

namespace BehavioralPatterns.Strategy
{
    public interface IDemodulator
    {
        List<double> Demodulate(List<double> telemetry);
    }
}
