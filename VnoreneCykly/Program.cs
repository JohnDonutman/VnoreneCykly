using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnoreneCykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte 1. číslo: ");
            string a_string = Console.ReadLine();
            Console.WriteLine("Zadejte 2. číslo: ");
            string b_string = Console.ReadLine();
            Console.WriteLine("Zadejte 3. číslo: ");
            string c_string = Console.ReadLine();
            Console.WriteLine("Zadejte poslední průchod: ");
            string pruchod_string = Console.ReadLine();

            int a = int.Parse(a_string);
            int b = int.Parse(b_string);
            int c = int.Parse(c_string);
            int pruchod = int.Parse(pruchod_string);

            int i = 0;
            int j = 0;
            int k = 0;

            int vycet = 0;

            for (i = 0; i <= a; i++)
            {
                for (j = 0; j <= b; j++)
                {
                    for (k = 0; k <= c; k++)
                    {
                        vycet++;
                        Console.WriteLine(vycet);
                        if (vycet == pruchod)
                        {
                            k++;
                            break;
                        }
                    }
                    if (vycet == pruchod)
                    {
                        j++;
                        break;
                    }
                }
                if (vycet == pruchod)
                {
                    i++;
                    break;
                }
            }
            Console.Write("Poslední průchod byl: " + i);
            Console.Write(", " + j);
            Console.WriteLine(", " + k);
        }
    }
}
