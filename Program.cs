using System;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mult = new int[100];  //tableau de 100 elements suffisant pour l'exemple, mais represantant une limite
            int input = 1, i = 0, calc = 1;
            string output = "";
            int keep = 1;
            Console.WriteLine("Rentrez une liste de nombres a multiplier");
            Console.WriteLine("Premier Nombre?");
            input = Convert.ToInt32(Console.ReadLine());
            mult[0] = input;
            Console.WriteLine("1 pour rajouter un chiffre, 0 pour arreter");
            keep = Convert.ToInt32(Console.ReadLine());
            while (keep == 1)       //on remplit le tableau en gardant dans i le nombre d'elements "interessants" dans le tableau
            {
                i++;
                Console.WriteLine("Prochain Nombre");
                input = Convert.ToInt32(Console.ReadLine());
                mult[i] = input;
                Console.WriteLine("1 pour rajouter un chiffre, 0 pour arreter");
                keep = Convert.ToInt32(Console.ReadLine());
            }
            for (int x = 0; x <= i; x++)    //on reutilise notre nombre d'elements pour parcourir le tableau
            {
                calc = calc * mult[x];
                if (x == 0)
                {
                    output = output + mult[x];
                }
                else
                {
                    output = output + " x " + mult[x];
                }
            }
            Console.WriteLine(output + " = " + calc);
        }
    }
}