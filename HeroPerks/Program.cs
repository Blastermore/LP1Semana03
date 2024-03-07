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

            int mark = 0;

            char w = char.Parse("w");
            char s = char.Parse("s");
            char a = char.Parse("a");
            char d = char.Parse("d");

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == w)
                {
                    myPerk ^= Perks.WaterBreathing;
                }
                else if (code[i] == s)
                {
                    myPerk ^= Perks.Stealth;

                }
                else if (code[i] == a)
                {
                    myPerk ^= Perks.AutoHeal;

                }
                else if (code[i] == d)
                {
                    myPerk ^= Perks.DoubleJump;

                }
                else
                {
                    mark += 1;
                    Console.WriteLine("Unknown perk!");
                    break;
                }
            }
            if (mark == 1)
            {
                return;
            }
            else if (myPerk == 0)
            {
                Console.WriteLine("No perks at all");
            }
            if (myPerk != 0)
            {
                Console.WriteLine(myPerk);
            }
            {
            if ((myPerk & Perks.Stealth) == Perks.Stealth)
            {
                if ((myPerk & Perks.DoubleJump) == Perks.DoubleJump)
                {
                    Console.WriteLine("Silent jumper!");
                }
            } 
            if ((myPerk & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
            }
        }
    }
}
