using PrimaryConstructors;

var logger = new LoggingService("INFO");
logger.Log("This is an informational message.");
Console.ReadLine();

/*
DI TIP
Microsoft.Extensions.DependencyInjection
Scrutor for scanning assemblies

services.Scan(scan =>
    scan.FromApplicationDependencies()
        .AddClasses(classes => classes.InNamespaces("IService"))
        .AsImplementedInterfaces()
        .WithTransientLifetime());
*/