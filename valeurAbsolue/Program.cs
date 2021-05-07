using System;

namespace valeurAbsolue
{
    class Program
    {
        //static double abs(double a)
        //{
        //    if (a < 0) a = -a;
         //   return a;
        //}
        
        static void Main(string[] args)
        {

            //variable         
            double a;            
            double b;

            //saisie
            Console.WriteLine(" Valeur absolue : ");
            Console.WriteLine(" ");
            Console.Write("Entre un nombre : ");

            // convertion du string en valeur int
            a = Convert.ToDouble(Console.ReadLine());

            //traitement
            b = a;
            if (a < 0) { a = -a; }
           
            //affichage
            Console.WriteLine("Valeur absolue de : " + b + " est : " + a);

            // attente de saisie fermeture fenetre 

            Console.ReadLine();
        }
    }
}
