using System;
using System.Collections.Generic;

public record OrderItemDto(Guid ProductId, int Quantity);
public record OrderCreatedEvent(Guid OrderId, Guid CustomerId, List<OrderItemDto> Items, DateTime CreatedAt);