internal class Program
{
    private static void Main(string[] args)
    {
        FileLogger fileLogger= new FileLogger();
        fileLogger.Writelog();
        DatabaseLogger databaseLogger= new DatabaseLogger();
        databaseLogger.Writelog();
        SMSLOgger sMSLOgger= new SMSLOgger();
        sMSLOgger.Writelog();

        LogManager logManager= new LogManager(new FileLogger());
        logManager.Writelog(); 
    }
}

interface ILogger
{
    void Writelog();
}

class LogManager{
    private ILogger _logger;

    public LogManager(ILogger logger)
    {
       _logger = logger;   
    }

    public void Writelog()
    {
        _logger.Writelog();
    }
}

class DatabaseLogger : ILogger
{
    public void Writelog()
    {
         Console.WriteLine("Database e  loglama yapar");
    }
}
class FileLogger : ILogger
{
    public void Writelog()
    {
         Console.WriteLine("dosyaya   loglama yapar");
    }
}

class SMSLOgger : ILogger
{
    public void Writelog()
    {
        Console.WriteLine("SMS olarak loglama yapar");
    }
}