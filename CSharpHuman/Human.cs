using System;

public class Human
{
    public string name;
    private int strength;
    private int intelligence;
    private int dexterity;
    public int health;

    public Human()
    {
        name = "Folk";
        Initialize(3, 3, 3, 100);
    }

    public Human( string humanName)
    {
        name = humanName;
        Initialize(3, 3, 3, 100);
    }

    public Human( string humanName, int humanStrength, int humanIntelligence, int humanDexterity, int humanHealth)
    {
        name = humanName;
        Initialize(humanStrength, humanIntelligence, humanDexterity, humanHealth);
    }

    private  void Initialize(int humanStrength, int humanIntelligence, int humanDexterity, int humanHealth)
    {
        strength = humanStrength;
        intelligence = humanIntelligence;
        dexterity = humanDexterity;
        health = humanHealth;
    }

    public void Attack(object h)
    {
        if (h is Human && (h as Human).name == name)
            Console.WriteLine("Can't hurt yourself!");

        if (h is Human && (h as Human).name != name)
            (h as Human).health -= (h as Human).strength * 5;
    }
}