using System;

namespace resolutionEq_methode
{
    public class Program
    {
        static void Main(string[] args)
        {
            //variable         
            double a, b;

            //titre
            Console.WriteLine(" Resolutoin d'équation (a * x + b = 0) --> x = -b/a");
            Console.WriteLine(" ");

            // saisie + convertion du string en valeur int
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
                //affichage solution
                Console.Write("Resolution de l'equation si a = " + a + " et b =" + b + " alors x = ");
                Console.WriteLine(CalculAB(a, b));
            }

            // attente de saisie fermeture fenetre 
            Console.ReadLine();

            }
        public static double CalculAB(double _a, double _b)
        {
            double solutionX = (-_b / _a);
            return solutionX;

        }
    }
}
