using System;
using System.Globalization;
using HeroPerks;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Powers power_player;

            Console.WriteLine("Insira o número de jogadores");
            int n = int.Parse(Console.ReadLine());

            string [][] player_powers = new string [n][];

            for ( int i = 0; i < n; i++)
            {
                Console.WriteLine("Do you have the power 'Fly'?");
                bool ask_power = bool.Parse(Console.ReadLine());

                if (ask_power)
                {
                    player_powers[i][0] =  Powers.Fly.ToString();
                }
                Console.WriteLine("Do you have the power 'FXRayVision'?");
                ask_power = bool.Parse(Console.ReadLine());

                if (ask_power)
                {
                    player_powers[i][1] =  Powers.XRayVision.ToString();
                }
                Console.WriteLine("Do you have the power 'SuperStrength'?");
                ask_power = bool.Parse(Console.ReadLine());

                if (ask_power)
                {
                    player_powers[i][2] =  Powers.SuperStrength.ToString();
                }   
            }
            for ( int i = 0; i < n; i++)
            {
                for (int j =0; j < 3; j++)
                {
                    Console.Write(player_powers[i][j]);
                if (player_powers[i][0] == "Fly" &&
                player_powers[i][2] == "SuperStrength")
                {
                    Console.Write("\nFlying radiation!");
                }
                }
            }


        }
    }
}
