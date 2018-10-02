using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CreationalPatterns.Tests")]
namespace CreationalPatterns.Builder
{
    internal class ApplicationBuilder : IApplicationBuilder
    {
        private readonly Application _application;

        public ApplicationBuilder()
        {
            _application = new Application();
        }

        public void ConnectToExternalTools()
        {
            _application.AssembliedMessage = string.Concat(_application.AssembliedMessage, "Tools Connected.");
        }

        public void CreateConnectedInstances()
        {
            _application.AssembliedMessage = string.Concat(_application.AssembliedMessage, "Connected Instances Connected.");
        }

        public void EstablichRabbitMQConnection()
        {
            _application.AssembliedMessage = string.Concat(_application.AssembliedMessage, "RabbitMQ Connected.");
        }

        public Application GetApplication()
        {
            return _application;
        }
    }
}
