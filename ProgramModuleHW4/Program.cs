using ProgramModuleHW4;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        IOrderProcessor orderProcessor = new OrderProcessor(logger);

        Order order = new Order
        {
            OrderId = 1,
            ProductName = "Телевизор",
            Quantity = 2
        };

        orderProcessor.ProcessOrder(order);
    }
}
