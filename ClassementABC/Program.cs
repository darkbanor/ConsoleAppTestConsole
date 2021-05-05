using System;
using System.Collections.Generic;

namespace ClassementABC
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            double a = 50;
            double b = 1;
            double c = 15;


            List<double> nombre = new List<double>();
            nombre.Add(a);
            nombre.Add(b);
            nombre.Add(c);

            //afficher liste non trier
            Console.WriteLine("Les éléments avant le tri :");
            foreach (double entree in nombre)
                Console.WriteLine(entree);
            
            //trier la liste
            nombre.Sort();

            //afficher liste trier
            Console.WriteLine(" ");
            Console.WriteLine("Les éléments après le tri :");
            foreach (double entree in nombre)
            Console.WriteLine(entree);

            // attente de saisie fermeture fenetre 
            Console.ReadLine();
        }
    }
}
