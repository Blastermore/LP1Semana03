using System;
using System.Runtime.InteropServices;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerk;
            myPerk = 0;

            string code = args[0];

            int counter_w = 0;
            int counter_s = 0;
            int counter_a = 0;
            int counter_d = 0;
            int mark = 0;

            char w = char.Parse("w");
            char s = char.Parse("s");
            char a = char.Parse("a");
            char d = char.Parse("d");

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == w)
                {
                    counter_w += 1;
                    myPerk ^= Perks.WaterBreathing;
                }
                else if (code[i] == s)
                {
                    counter_s += 1;
                    myPerk ^= Perks.Stealth;
                }
                else if (code[i] == a)
                {
                    counter_a += 1;
                    myPerk ^= Perks.AutoHeal;
                }
                else if (code[i] == d)
                {
                    counter_d += 1;
                    myPerk ^= Perks.DoubleJump;
                }
                else
                {
                    mark += 1;
                    Console.WriteLine("Unknown perk!");
                    break;
                }
            }
            if (myPerk == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else if (myPerk != 0 && mark != 1)
            {
                Console.WriteLine(myPerk);
                if ((myPerk & Perks.Stealth) == Perks.Stealth)
                {
                    if ((myPerk & Perks.DoubleJump) == Perks.DoubleJump)
                    {
                        Console.WriteLine("Silent jumper!");
                    }
                }
                if ((myPerk & Perks.AutoHeal) != Perks.AutoHeal || myPerk == 0)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }
                Console.WriteLine(Perks.AutoHeal);
        }
    }
}
