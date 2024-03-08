using System;
using System.Globalization;
using HeroPerks;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ask_power = false;
            Console.WriteLine("Insira o número de jogadores");
            int n = int.Parse(Console.ReadLine());

            string [][] player_powers = new string [n][];

            for ( int i = 0; i < n; i++)
            {
                player_powers[i] = new string [3] {"","",""};

                Console.WriteLine("Do you have the power 'Fly'?");
                ask_power = bool.Parse(Console.ReadLine());

                if (ask_power)
                {
                    player_powers[i][0] = Powers.Fly.ToString();
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
                Console.Write($"O jogador {i + 1} tem: ");
                for (int j =0; j < 3; j++)
                {
                    string power = player_powers[i][j];
                    if (player_powers[i][j] != "")
                    {
                        Console.Write($"{power} ");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine("");
                if (player_powers[i][0] == "Fly" &&
                player_powers[i][2] == "SuperStrength")
                {
                    Console.WriteLine("Flying radiation!");
                }
            }


        }
    }
}
