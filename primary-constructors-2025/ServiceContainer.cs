namespace PrimaryConstructors;

//services.AddSingleton<IServiceFactory, ServiceFactory>();
public sealed class ServiceContainer
{
    public ILoggingService LoggingService { get; }
    public IUserService UserService { get; }
    public IProductService ProductService { get; }
    public IEmailService EmailService { get; }
    public INotificationService NotificationService { get; }

    public ServiceContainer(
        ILoggingService loggingService,
        IUserService userService,                           
        IProductService productService,
        IEmailService emailService,
        INotificationService notificationService)
    => (this.LoggingService, this.UserService, this.ProductService, this.EmailService, this.NotificationService) =
        (loggingService, userService, productService, emailService, notificationService);
}
