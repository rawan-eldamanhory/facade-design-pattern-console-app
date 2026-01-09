# Facade Design Pattern – C#

This project demonstrates the **Facade Design Pattern** using a simple shape-drawing example in C#.

## What is the Facade Pattern?
The Facade Pattern provides a **simplified interface** to a complex subsystem.  
It hides implementation details and exposes only what the client needs.

## Project Structure
- `IShape` – Interface defining the draw operation
- `Circle`, `Square`, `Rectangle` – Concrete shape implementations
- `ShapeMakerFacade` – Facade class that simplifies shape creation and drawing
- `Program` – Client code using the facade

## Example Usage
```csharp
ShapeMakerFacade ShapeMakerFacade = new ShapeMakerFacade();
ShapeMakerFacade.DrawCircle();
ShapeMakerFacade.DrawSquare();
ShapeMakerFacade.DrawRectangle();
```

## Output
I will draw circle.
I will draw square.
I will draw rectangle.

## Concepts Demonstrated
- Facade Design Pattern
- Interface-based programming
- Encapsulation
- Loose coupling

## Technologies
- C#
- Console Application
- Visual Studio
