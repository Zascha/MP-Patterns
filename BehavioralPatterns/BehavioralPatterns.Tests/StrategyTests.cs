using System;
using System.Collections.Generic;
using System.Linq;
using BehavioralPatterns.Strategy;
using Xunit;

namespace BehavioralPatterns.Tests
{
    public class StrategyTests
    {
        private readonly List<double> _testDoubleArray;

        public StrategyTests()
        {
            _testDoubleArray = TestData.NumericList;
        }

        [Fact]
        public void Demodulator_PassedNullDemodulatorObject_ThrowsArgumentNullException()
        {
            IDemodulator nullDemodulator = null;

            Assert.Throws<ArgumentNullException>(() => new Demodulator(nullDemodulator));
        }

        [Fact]
        public void Demodulator__Demodulate_PassedNullListValue_ThrowsArgumentNullException()
        {
            List<double> nullList = null;
            var simpleDemodulator = new Demodulator(new SimpleDemodulator());
            var noisyDemodulator = new Demodulator(new NoizyDemodulator());

            Assert.Throws<ArgumentNullException>(() => simpleDemodulator.Demodulate(nullList));
            Assert.Throws<ArgumentNullException>(() => noisyDemodulator.Demodulate(nullList));
        }

        [Fact]
        public void Demodulator_Demodulate_SimpleDemodulatorStrategy_ReturnsListModifiedAccordingToSimpleDemodulatorLogic()
        {
            var expectedResult = TestData.SimpleDemodulationHandlerLogic(_testDoubleArray.First());
            var demodulator = new Demodulator(new SimpleDemodulator());

            var actualResult = demodulator.Demodulate(_testDoubleArray);

            Assert.Equal(expectedResult, actualResult.First());
        }
        [Fact]
        public void Demodulator_Demodulate_NoizyDemodulatorStrategy_ReturnsListModifiedAccordingToNoizyDemodulatorLogic()
        {
            var expectedResult = TestData.NoizyDemodulationHandlerLogic(_testDoubleArray.First());
            var demodulator = new Demodulator(new NoizyDemodulator());

            var actualResult = demodulator.Demodulate(_testDoubleArray);

            Assert.Equal(expectedResult, actualResult.First());
        }
    }
}
