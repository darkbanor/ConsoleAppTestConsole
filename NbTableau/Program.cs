using System;

namespace NbTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            int [] nombre = { 1, 45, 8, 15, 88 };           
            int longNombre = nombre.Length;
            int nombreUser;
            string userInputa;
            
            //traitement
            Array.Sort(nombre);

            foreach (int i in nombre)
                {
                Console.Write(" " + i);
                }

            //affichage saisie
            Console.WriteLine();
            Console.WriteLine("Votre tableau contient : " + longNombre + " elements");

            Console.WriteLine();

            Console.Write("Entrez un chiffre du tableau et je vous dirais dans quelle colone il se trouve --> ");

            userInputa = Console.ReadLine();

            nombreUser = Convert.ToInt16(userInputa);

            //recherche colone
            for (int i=0; i<longNombre; i++)
            {
               if (nombre [i] == nombreUser)
                {
                    Console.WriteLine("C'est la colone " + i);
                }
            }

            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
        }
    }
}
