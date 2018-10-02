using BehavioralPatterns.State;
using Xunit;

namespace BehavioralPatterns.Tests
{
    public class StateTests
    {
        private readonly NoizyDemodulator _noizyDemodulator;
        private readonly SimpleDemodulator _simpleDemodulator;

        public StateTests()
        {
            _noizyDemodulator = new NoizyDemodulator();
            _simpleDemodulator = new SimpleDemodulator();
        }

        [Fact]
        public void NoizyDemodulator_Demodulate_ValueMoreThanLimitValueAndSimpleDemodulator_ReturnsValueModifiedBySimpleDemodulatorLogic()
        {
            var value = TestData.DemodulationHandlerLimit + 100;
            var expectedResult = TestData.SimpleDemodulationHandlerLogic(value);

            var demodulation = new Demodulation
            {
                Value = value,
                Demodulator = new SimpleDemodulator()
            };

            var actualResult = _noizyDemodulator.Demodulate(demodulation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void NoizyDemodulator_Demodulate_ValueLessThanLimitValueAndSimpleDemodulator__ReturnsValueModifiedByNoizyDemodulatorLogic()
        {
            var value = TestData.DemodulationHandlerLimit - 100;
            var expectedResult = TestData.NoizyDemodulationHandlerLogic(value);

            var demodulation = new Demodulation
            {
                Value = value,
                Demodulator = new SimpleDemodulator()
            };

            var actualResult = _noizyDemodulator.Demodulate(demodulation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void SimpleDemodulator_Demodulate_ValueMoreThanLimitValueAndNoizyDemodulator_ReturnsValueModifiedByNoisyDemodulatorLogic()
        {
            var value = TestData.DemodulationHandlerLimit + 100;
            var expectedResult = TestData.NoizyDemodulationHandlerLogic(value);

            var demodulation = new Demodulation
            {
                Value = value,
                Demodulator = new NoizyDemodulator()
            };

            var actualResult = _simpleDemodulator.Demodulate(demodulation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void SimpleDemodulator_Demodulate_ValueLessThanLimitValueAndNoizyDemodulator__ReturnsValueModifiedBySimpleDemodulatorLogic()
        {
            var value = TestData.DemodulationHandlerLimit - 100;
            var expectedResult = TestData.SimpleDemodulationHandlerLogic(value);

            var demodulation = new Demodulation
            {
                Value = value,
                Demodulator = new NoizyDemodulator()
            };

            var actualResult = _simpleDemodulator.Demodulate(demodulation);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
