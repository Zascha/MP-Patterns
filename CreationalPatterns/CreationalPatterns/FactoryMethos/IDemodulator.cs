using System.Collections.Generic;

namespace CreationalPatterns.FactoryMethos
{
    public interface IDemodulator
    {
        List<double> Demodulate(List<double> telemetry);
    }
}
