using System;

namespace CercleAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            //definition de variable

            string userInputr; // variable pour la saisie r
            string userInputa; // variable pour la saisie a

            double r; //nombre r pour rayon
            double a; //nombre r pour rayon
            double aircirc; //variable pour l'air
            double pi = Math.PI; //def de pi
            
            //saisie
            Console.WriteLine("Ex 1 : Calcul d'aire du secteur circulaire ");
            Console.WriteLine(" ");
            Console.Write("Entre un nombre pour le rayon d'une sphere : ");
            userInputr = Console.ReadLine();
            Console.Write("Entre un nombre qui represente les degres  : ");
            userInputa = Console.ReadLine();

            //traitement-calcul


            // convertion du string en valeur int
            r = Convert.ToDouble(userInputr);
            a = Convert.ToDouble(userInputa);

            double rcarre = Math.Pow(r, 2); //le carre de r
            
            // calcul aire circulaire

            aircirc = pi * rcarre * a /360; // calcul l'air d'une spherecalcul aire circulaire

            //limitation apres la virgule
            double vair = Math.Round(aircirc, 3);
           
            //affichage

            Console.WriteLine(" ");
            Console.Write("L'air de la sphere est : " + vair);
            Console.WriteLine(" ");
            Console.WriteLine(" fin ");

            // attente de saisie fermeture fenetre 
            Console.ReadLine();
            
        }
    }
}
