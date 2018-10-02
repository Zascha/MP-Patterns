using System;
using System.Collections.Generic;
using System.Linq;
using CreationalPatterns.FactoryMethos;
using Xunit;

namespace CreationalPatterns.Tests
{
    public class FactoryTests
    {
        private readonly List<double> _testDoubleArray;
        private readonly Func<double, double> _noizyDemodulationHandlerLogic;
        private readonly Func<double, double> _simpleDemodulationHandlerLogic;

        public FactoryTests()
        {
            _testDoubleArray = TestData.NumericList;

            _noizyDemodulationHandlerLogic = value => Math.Round(value * 2, 2);
            _simpleDemodulationHandlerLogic = value => value * 2;
        }

        [Fact]
        public void GetDemodulator_SimpleDemodulator_NullListValue_ThrowsNullReferenceException()
        {
            List<double> nullList = null;
            var inputStringParam = "sand";

            var demodulatorInstance = Demodulator.GetDemodulator(inputStringParam);

            Assert.NotNull(demodulatorInstance);
            Assert.Throws<NullReferenceException>(() => demodulatorInstance.Demodulate(nullList));
        }

        [Fact]
        public void GetDemodulator_SimpleDemodulator_NotNullListValue_ReturnsModifiedInputArrayAccordingToSimpleDemodulatorLogic()
        {
            var inputStringParam = "sand";
            var expectedResult = _simpleDemodulationHandlerLogic(_testDoubleArray.First());

            var demodulatorInstance = Demodulator.GetDemodulator(inputStringParam);
            var modifiedArray = demodulatorInstance.Demodulate(_testDoubleArray);

            Assert.NotNull(demodulatorInstance);
            Assert.IsType<SimpleDemodulator>(demodulatorInstance);
            Assert.NotEmpty(modifiedArray);
            Assert.Equal(expectedResult, modifiedArray.First());
        }

        [Fact]
        public void GetDemodulator_NoizyDemodulator_NullListValue_ThrowsNullReferenceException()
        {
            List<double> nullList = null;
            var inputStringParam = "not-sand";

            var demodulatorInstance = Demodulator.GetDemodulator(inputStringParam);

            Assert.NotNull(demodulatorInstance);
            Assert.Throws<NullReferenceException>(() => demodulatorInstance.Demodulate(nullList));
        }

        [Fact]
        public void GetDemodulator_NoizyDemodulator_NotNullListValue_ReturnsModifiedInputArrayAccordingToNoizyDemodulatorLogic()
        {
            var inputStringParam = "not-sand";
            var expectedResult = _noizyDemodulationHandlerLogic(_testDoubleArray.First());

            var demodulatorInstance = Demodulator.GetDemodulator(inputStringParam);
            var modifiedArray = demodulatorInstance.Demodulate(_testDoubleArray);

            Assert.NotNull(demodulatorInstance);
            Assert.IsType<NoizyDemodulator>(demodulatorInstance);
            Assert.NotEmpty(modifiedArray);
            Assert.Equal(expectedResult, modifiedArray.First());
        }
    }
}
