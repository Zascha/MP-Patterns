using Xunit;

namespace CreationalPatterns.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void GetInstance_CreatedInstanceOfATypeIsNotNull()
        {
            var singleton = Singleton.GetInstance;

            Assert.NotNull(singleton);
        }

        [Fact]
        public void GetInstance_CreatesOnlyOneInstanceOfAType()
        {
            var singletonFirstInstance = Singleton.GetInstance;
            var singletonSecondInstance = Singleton.GetInstance;

            Assert.NotNull(singletonFirstInstance);
            Assert.NotNull(singletonSecondInstance);
            Assert.Same(singletonFirstInstance, singletonSecondInstance);
        }
    }
}
