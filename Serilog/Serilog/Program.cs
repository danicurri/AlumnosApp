using System;

namespace Serilog
{
    public class HelloSerilog
    {
        static void Main(string[] args)
        {
            //Create Logger
            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.ColoredConsole()
                .WriteTo.RollingFile(@"C:\Users\Daniel Contreras\source\repos\Serilog\Serilog\Log-{Date}.txt")
                .CreateLogger();
            // prepare data
            var order = new { Id = 12, Total = 128.50, CustomerId = 72 };
            var customer = new { Id = 72, Name = "John Smith" };
            // write log message
            logger.Information("New orders {OrderId} by {Customer}", order.Id, customer);
            logger.Debug("Debugging message");
            logger.Information("Information message");
            logger.Warning("Warning message");
            logger.Error("Error message");
            logger.Fatal("Fatal message");
            Console.ReadKey();
        }
    }
}
