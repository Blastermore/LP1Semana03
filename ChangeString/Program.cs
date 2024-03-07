using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere uma string");
            string s = Console.ReadLine();

            Console.WriteLine("Insere um caracter");
            char c = char.Parse(Console.ReadLine());

            string s_final = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    s_final += "X";
                }
                else
                {
                    s_final += s[i];
                }
            }
            Console.WriteLine(s_final);
        }
    }
}
