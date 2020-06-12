using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet yummy= new Buffet();
            SweetTooth kyle = new SweetTooth();
            SpiceHound dude = new SpiceHound();
            while (!kyle.IsFull)
            {
                kyle.Consume(yummy.Serve());
            }
            if (kyle.ConsumptionHistory.Count > dude.ConsumptionHistory.Count)
            {
                Console.WriteLine($"SweetTooth had the most items consumed with {kyle.ConsumptionHistory.Count} items!");
            }
            else
            {
                Console.WriteLine($"SweetTooth had the most items consumed with {dude.ConsumptionHistory.Count} items!");
            }
        }
    }
}
