using System;

namespace ConsoleAppMoyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            //definition de variable

            string userInputa; // variable pour la saisie a
            string userInputb; // variable pour la saisie b

            double a; //nombre a pour les moyennes
            double b; //nombre b pour les moyenne
            double moyenne; // moyenne

            //saisie
            Console.WriteLine("Ex 1 : Calcul de moyenne ");
            Console.WriteLine(" ");
            Console.Write("Entre un nombre pour a : ");
            userInputa = Console.ReadLine();
            Console.Write("Entre un nombre pour b : ");
            userInputb = Console.ReadLine();

            //traitement-calcul

            // convertion du string en valeur int
            a = Convert.ToDouble(userInputa);
            b = Convert.ToDouble(userInputb);

            // calcul de moyenne a et b

            moyenne = (a + b) / 2;

            //affichage

            Console.WriteLine(" -- Calcul de moyenne --");
            Console.WriteLine(" ");
            Console.WriteLine("La moyenne entre "+a+" et "+b+" est : "+moyenne);
            Console.WriteLine(" ");
            Console.WriteLine(" fin ");

            // attente de saisie fermeture fenetre 
            Console.ReadLine();


        }
    }
}
