using System;

public interface ICharacter
{
    public string SpecialMove();
}
public class Warrior() : ICharacter
{
    public string SpecialMove()
    {
        return ("Death by a Thousand Cuts!");
    }
}
public class Mage() : ICharacter
{
    public string SpecialMove()
    {
        return ("Magic Star!");
    }
}
public class Archer() : ICharacter
{
    public string SpecialMove()
    {
        return ("Thousand Arrows!");
    }
}
public class CharacterFactory()
{
    public static ICharacter CreateCharacter(string type)
    {
        return type switch
        {
            "Warrior" => new Warrior(),
            "Mage" => new Mage(),
            "Archer" => new Archer(),
            _ => throw new ArgumentException($"Unknown character type: {type}", nameof(type)),
        };
    }
}