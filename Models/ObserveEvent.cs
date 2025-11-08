using System;

public class Stock
{
    public string Symbol { get; }
    public decimal Price { get; private set; }

    public Stock(string symbol, decimal initialPrice)
    {
        Symbol = symbol ?? throw new ArgumentNullException(nameof(symbol));
        Price = initialPrice;
    }

    public void SetPrice(decimal newPrice)
    {
        if(newPrice == Price) return;

        Price = newPrice;
        PriceChanged?.Invoke(this, Price);
        
    }
    public event EventHandler<decimal>? PriceChanged;
}

public class PortfolioDisplay
{
    public void OnPriceChanged(object? sender, decimal price)
    {
        Console.WriteLine($"Portfolio display: {((Stock)sender!).Symbol} now {price:C}");
    }
}

public class MobileAlert
{
    public void OnPriceChanged(object? sender, decimal price)
    {
        Console.WriteLine($"Mobile alert: {((Stock)sender!).Symbol} price changed to {price:C}");
    }
}

