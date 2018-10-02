using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Strategy
{
    public class Demodulator
    {
        private readonly IDemodulator _demodulator;

        public Demodulator(IDemodulator demodulator)
        {
            _demodulator = demodulator ?? throw new ArgumentNullException(nameof(demodulator));
        }

        public List<double> Demodulate(List<double> values)
        {
            if(values == null)
                throw new ArgumentNullException(nameof(values));

            return _demodulator.Demodulate(values);
        }
    }
}
