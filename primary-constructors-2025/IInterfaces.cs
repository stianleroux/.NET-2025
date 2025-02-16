namespace PrimaryConstructors;

public interface ILoggingService
{
    void Log(string message);
}

public interface IUserService
{
    void AddUser(string name);
}

public interface IProductService
{
    void AddProduct(string name);
}

public interface IEmailService
{
    void SendEmail(string to, string subject);
}

public interface INotificationService
{
    void SendNotification(string message);
}
