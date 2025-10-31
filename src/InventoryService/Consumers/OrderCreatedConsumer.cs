using MassTransit;
using System.Threading.Tasks;

public class OrderCreatedConsumer : IConsumer<OrderCreatedEvent>
{
    private readonly InventoryDbContext _db;

    public OrderCreatedConsumer(InventoryDbContext db)
    {
        _db = db;
    }

    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        foreach (var item in context.Message.Items)
        {
            var product = await _db.Products.FindAsync(item.ProductId);
            if (product != null)
            {
                product.Quantity -= item.Quantity;
            }
        }

        await _db.SaveChangesAsync();
    }
}