using System;

namespace equationResolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            //variable         
            double a, b, x;

            //saisie
            Console.WriteLine(" Resolutoin d'équation (a * x + b = 0) --> x = -b/a");
            Console.WriteLine(" ");

            // convertion du string en valeur int
            Console.Write("Entre un nombre pour a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entre un nombre pour b: ");
            b = Convert.ToDouble(Console.ReadLine());



            //traitement          

            if (a == 0 && b == 0)
            {
                Console.WriteLine("equation indetermine");
                Console.ReadLine();
               
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("equation impossible");
                Console.ReadLine();               
            }
            else
            {
                x = (-b / a);

                //affichage
                Console.WriteLine("Resolution de l'equation si a = " + a + " et b =" + b + " alors x = " + Math.Round(x));

               
            }

            // attente de saisie fermeture fenetre 
            Console.ReadLine();




        }

    }
}
