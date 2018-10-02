using CreationalPatterns.Builder;
using Xunit;

namespace CreationalPatterns.Tests
{
    public class BuilderTests
    {
        private readonly IApplicationBuilder _builder;

        public BuilderTests()
        {
            _builder = new ApplicationBuilder();
        }

        [Fact]
        public void GetApplication_ReturnsApplicationTypeObject()
        {
            var applicationInstance = _builder.GetApplication();

            Assert.NotNull(applicationInstance);
            Assert.IsType<Application>(applicationInstance);
        }

        [Fact]
        public void ConnectToExternalTools_ModifiesApplicationTypeObjectAssembliedMessage()
        {
            var expectedAssembliedMessage = "Tools Connected.";

            _builder.ConnectToExternalTools();
            var applicationInstance = _builder.GetApplication();

            Assert.NotNull(applicationInstance);
            Assert.IsType<Application>(applicationInstance);
            Assert.Equal(expectedAssembliedMessage, applicationInstance.AssembliedMessage);
        }

        [Fact]
        public void CreateConnectedInstances_ModifiesApplicationTypeObjectAssembliedMessage()
        {
            var expectedAssembliedMessage = "Connected Instances Connected.";

            _builder.CreateConnectedInstances();
            var applicationInstance = _builder.GetApplication();

            Assert.NotNull(applicationInstance);
            Assert.IsType<Application>(applicationInstance);
            Assert.Equal(expectedAssembliedMessage, applicationInstance.AssembliedMessage);
        }

        [Fact]
        public void EstablichRabbitMQConnection_ModifiesApplicationTypeObjectAssembliedMessage()
        {
            var expectedAssembliedMessage = "RabbitMQ Connected.";

            _builder.EstablichRabbitMQConnection();
            var applicationInstance = _builder.GetApplication();

            Assert.NotNull(applicationInstance);
            Assert.IsType<Application>(applicationInstance);
            Assert.Equal(expectedAssembliedMessage, applicationInstance.AssembliedMessage);
        }
    }
}
