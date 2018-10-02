using CreationalPatterns.Prototype;
using Xunit;

namespace CreationalPatterns.Tests
{
    public class PrototypeTests
    {
        private readonly LargeObject _largeObject;

        public PrototypeTests()
        {
            _largeObject = TestData.LargeObject;
        }

        [Fact]
        public void CloneSelf_ReturnsAnObjectWithEqualValueTypesValuesAndTheSameReferenceTypesValues()
        {
            var largeObjectCopy = _largeObject.CloneSelf();

            Assert.NotNull(largeObjectCopy);
            Assert.IsType<LargeObject>(largeObjectCopy);

            Assert.NotSame(_largeObject, largeObjectCopy);
            Assert.Equal(_largeObject.IntField, largeObjectCopy.IntField);
            Assert.Same(_largeObject.StringField, largeObjectCopy.StringField);
        }

        [Fact]
        public void DeepClone_ReturnsAnObjectWithEqualValueTypesValuesAndNotTheSameReferenceTypesValues()
        {
            var largeObjectCopy = _largeObject.DeepClone();

            Assert.NotNull(largeObjectCopy);
            Assert.IsType<LargeObject>(largeObjectCopy);

            Assert.NotSame(_largeObject, largeObjectCopy);
            Assert.Equal(_largeObject.IntField, largeObjectCopy.IntField);
            Assert.NotSame(_largeObject.StringField, largeObjectCopy.StringField);
        }
    }
}
