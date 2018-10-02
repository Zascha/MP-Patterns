﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CreationalPatterns.Tests")]
namespace CreationalPatterns.FactoryMethos
{
    internal class SimpleDemodulator : IDemodulator
    {
        public List<double> Demodulate(List<double> telemetry)
        {
            var demodulatedData = new List<double>();
            foreach (var value in telemetry)
            {
                demodulatedData.Add(value * 2);
            }
            return demodulatedData;
        }
    }
}
