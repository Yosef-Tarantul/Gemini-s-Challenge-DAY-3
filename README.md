# Training.OOP.DAY3

## Overview
- Initialized a C# console project with `dotnet new console`.
- Implemented the **Factory** pattern via `CharacterFactory` and character classes (`Warrior`, `Mage`, `Archer`) returning distinct special moves.
- Built the **Strategy** pattern for shipping cost calculation:
  - Created `Order` that delegates `GetTotalCost()` to a pluggable `IShippingStrategy`.
  - Added concrete strategies (`FedExStrategy`, `UpsStrategy`, `UspsStrategy`) with different pricing formulas.
  - Demonstrated usage in `Program.cs` by assigning a strategy instance and formatting output as currency.
- Set up the **Observer/Event** pattern scaffolding for stock price alerts:
  - Added `Stock` with an event-based `PriceChanged` notification.
  - Created observer classes `PortfolioDisplay` and `MobileAlert` with handlers to react when subscribed.
  - Hooked observers in `Program.cs` and raised `PriceChanged` by updating the stock price.

## Key Learnings
- How to structure and initialize a .NET console application.
- Applying common OO design patterns (Factory, Strategy, Observer) in C#.
- Using events/delegates to broadcast state changes (`EventHandler<T>`).
- Formatting output with standard numeric format strings (`:C` for locale-aware currency).
- Managing Git branches (`main`, feature branches like `Strategy`) and keeping IDE-specific files out of source control via `.gitignore`.

## Next Steps
- Expand the observer logic (e.g., multiple stocks, unsubscribe scenarios).
- Add unit tests covering factory creation and strategy calculations.
- Document design decisions inline (XML comments) or via additional markdown sections if needed.
# Gemini-s-Challenge-DAY-3
In this day I practice: factory pattern, strategy pattern and observer/event.
