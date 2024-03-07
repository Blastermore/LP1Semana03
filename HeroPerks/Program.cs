using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerk;
            myPerk = 0;

            int counter_w = 0;
            int counter_s = 0;
            int counter_a = 0;
            int counter_d = 0;

            //char w = char.Parse("w");
            //char s = char.Parse("s");
            //char a = char.Parse("a");
            //char d = char.Parse("d");


            string command = Console.ReadLine();

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "w")
                {
                    counter_w += 1;
                    myPerk ^= Perks.WaterBreathing;
                }
                else if (args[i] == "s")
                {
                    counter_s += 1;
                    myPerk ^= Perks.Stealth;
                }
                else if (args[i] == "a")
                {
                    counter_a += 1;
                    myPerk ^= Perks.AutoHeal;
                }
                else if (args[i] == "d")
                {
                    counter_d += 1;
                    myPerk ^= Perks.DoubleJump;
                }
                else
                {
                    Console.WriteLine("Unknown perk!");
                    break;
                }
            }
            if (myPerk == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else if (myPerk != 0)
            {
                Console.Write(myPerk);
                if ((myPerk & Perks.Stealth) == Perks.Stealth)
                {
                    if ((myPerk & Perks.DoubleJump) == Perks.DoubleJump)
                    {
                        Console.WriteLine("Silent jumper!");
                    }
                }
                else if ((myPerk & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }

        }
    }
}
