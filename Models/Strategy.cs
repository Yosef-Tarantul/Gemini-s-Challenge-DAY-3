using System;

public class Order
{
    public decimal Weight { get; set; }
    public decimal Distance { get; set; }
    public IShippingStrategy ShippingStrategy { get; set; } = null!;

    public decimal GetTotalCost()
    {
        if (ShippingStrategy is null)
        {
            throw new InvalidOperationException("Shipping strategy must be assigned before calculating cost.");
        }

        return ShippingStrategy.CalculateCost(this);
    } 

}

public interface IShippingStrategy
{
    decimal CalculateCost(Order order);
}

public class FedExStrategy : IShippingStrategy
{
    public decimal CalculateCost(Order order)
    {
        if (order is null)
        {
            throw new ArgumentNullException(nameof(order));
        }

        const decimal baseRate = 5m;
        const decimal weightRate = 1.5m;
        const decimal distanceRate = 0.05m;

        return baseRate + (order.Weight * weightRate) + (order.Distance * distanceRate);
    }
}

public class UpsStrategy : IShippingStrategy
{
    public decimal CalculateCost(Order order)
    {
        if (order is null)
        {
            throw new ArgumentNullException(nameof(order));
        }

        const decimal baseRate = 7m;
        const decimal weightRate = 1.2m;
        const decimal distanceRate = 0.04m;

        return baseRate + (order.Weight * weightRate) + (order.Distance * distanceRate);
    }
}

public class UspsStrategy : IShippingStrategy
{
    public decimal CalculateCost(Order order)
    {
        if (order is null)
        {
            throw new ArgumentNullException(nameof(order));
        }

        const decimal baseRate = 4m;
        const decimal weightRate = 1.0m;
        const decimal distanceRate = 0.03m;

        return baseRate + (order.Weight * weightRate) + (order.Distance * distanceRate);
    }
}