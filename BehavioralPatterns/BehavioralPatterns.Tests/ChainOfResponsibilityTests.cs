using BehavioralPatterns.ChainOfResponcibility;
using Xunit;

namespace BehavioralPatterns.Tests
{
    public class ChainOfResponsibilityTests
    {
        private readonly Demodulation _demodulation;

        public ChainOfResponsibilityTests()
        {
           _demodulation = Demodulation.GetInstance;
        }

        [Fact]
        public void Demodulate_ValueIsMoreThanSimpleDemodulationHandlerLimit_ReturnsModifiedAccordingToNoizyDemodulationHandlerLogic()
        {
            var testValue = TestData.DemodulationHandlerLimit + 100;
            var expectedResult = TestData.NoizyDemodulationHandlerLogic(testValue);

            var actualResult = _demodulation.Demodulate(testValue);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Demodulate_ValueIsLessThanSimpleDemodulationHandlerLimit_ReturnsModifiedAccordingToSimpleDemodulationHandlerLogic()
        {
            var testValue = TestData.DemodulationHandlerLimit - 100;
            var expectedResult = TestData.SimpleDemodulationHandlerLogic(testValue);

            var actualResult = _demodulation.Demodulate(testValue);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
