namespace PrimaryConstructors;

public sealed class ServiceContainerExample(ServiceContainer serviceFactory)
{
    public void Run() => serviceFactory.LoggingService.Log("Hello World");
}
