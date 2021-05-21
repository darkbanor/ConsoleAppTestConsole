using System;

namespace Nombre1er
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            bool premier = true;
            int nombre;
            int reste;

            //saisie du nombre à determiner si 1er          
            Console.Write(" Entrez le nombre entre 2 et infini : ");
            nombre = int.Parse(Console.ReadLine());

            //calcul du nombre 1er
            int i = 2;

            while (i < nombre && premier == true)
            {
                reste = nombre % i;

                if (reste == 0)
                {
                    premier = false;
                }

                i++;
            }

            //affichage résultats
            if (premier == true)
            {
                Console.WriteLine("votre chiffre est premier");
            }
            else
            {
                Console.WriteLine("votre chiffre n'est pas premier");
            }



            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
        }
    }
}
