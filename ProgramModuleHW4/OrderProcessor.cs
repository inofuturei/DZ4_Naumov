using ProgramModuleHW4;

public class OrderProcessor : IOrderProcessor
{
    private readonly ILogger _logger;

    public OrderProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessOrder(Order order)
    {
        // Логика обработки заказа
        Console.WriteLine($"Обработка заказа №: {order.OrderId}, Продукт: {order.ProductName}, Количество: {order.Quantity}");

        // Логирование результата
        _logger.Log($"Заказ {order.OrderId} успешно обработан.");
    }
}
