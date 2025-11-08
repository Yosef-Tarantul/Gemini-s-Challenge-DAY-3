// See https://aka.ms/new-console-template for more information
using System.Buffers;

ICharacter p1 = CharacterFactory.CreateCharacter("Warrior");
Console.WriteLine(p1.SpecialMove());

Order order = new Order
{
    Weight = 10m,
    Distance = 250m,
    ShippingStrategy = new FedExStrategy()
};

Console.WriteLine($"Shipping cost (FedEx): {order.GetTotalCost():C}");



Stock AAPL = new Stock("APPL", 875 );
PortfolioDisplay display = new PortfolioDisplay();
MobileAlert alert = new MobileAlert();

AAPL.PriceChanged += display.OnPriceChanged;
AAPL.PriceChanged += alert.OnPriceChanged;

AAPL.SetPrice(200);

