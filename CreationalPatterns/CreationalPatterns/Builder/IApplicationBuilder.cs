namespace CreationalPatterns.Builder
{
    public interface IApplicationBuilder
    {
        void ConnectToExternalTools();
        void CreateConnectedInstances();
        void EstablichRabbitMQConnection();

        Application GetApplication();
    }
}
