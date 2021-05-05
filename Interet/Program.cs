using System;

namespace Interet
{
    class Program
    {
        static void Main(string[] args)
        {
            //definition de variable saisie
            string userInputsommes; // variable pour la saisie de la somme (euro)
            string userInputinteret; // variable pour la saisie i interet
            string userInputannee; // variable pour nombre annees

            //definition de variable int
            double interet; //interet
            int annee; //nombre d'annee


            //definition de variable double
            double sommes; // euro placer sur un compte
            double isimple; // interet simple
            double icompose; // interet compose
            double pcomp; // pour calculer interet compose

            //saisie
            Console.WriteLine(" -- Calcul d'interet -- ");
            Console.WriteLine(" ");
            Console.Write("Sommes initiale place sur un compte : ");
            userInputsommes = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Entre l'interet sans le % : ");
            userInputinteret = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Nombre d'annees de placement  : ");
            userInputannee = Console.ReadLine();

            
            // convertion du string en valeur int
            sommes = Convert.ToDouble(userInputsommes);
            annee = Convert.ToInt32(userInputannee);
            
            interet = Convert.ToDouble(userInputinteret) / 100d;

            //traitement-calcul
            isimple = sommes * (1 + annee * interet); // calcul interet simple
            pcomp = interet + 1; // calcul de la puissance de l'interet compose
            icompose = sommes * Math.Pow(pcomp, annee); // calcul de l'interet compose

            //affichage

            Console.WriteLine(" ");
            Console.WriteLine(sommes + " euros placés pendant : " + annee + " ans avec un interet de : " + interet + " % = " + isimple);
            Console.WriteLine(" ");
            Console.WriteLine("et composés : " + icompose);
            Console.WriteLine(" ");
            Console.WriteLine(" fin ");

            // attente de saisie fermeture fenetre 
            Console.ReadLine();



        }
    }
}

