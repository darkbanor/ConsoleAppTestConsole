using System;

namespace Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            //definition de variable

            string userInputr; // variable pour la saisie r
            
            double rayon; //nombre r pour rayon
            double aire; //variable pour l'air
            double pi = Math.PI; //def de pi
            double volume; // volume

            //saisie
            Console.WriteLine("Ex 1 : Calcul d'aire et volumes ");
            Console.WriteLine(" ");
            Console.Write("Entre un nombre pour le rayon d'une sphere : ");
            userInputr = Console.ReadLine();

            //traitement-calcul
           

            // convertion du string en valeur int
            rayon = Convert.ToDouble(userInputr);

            double rcarre = Math.Pow(rayon, 2); //le carre de r
            double rcube = Math.Pow(rayon, 3); //le cube de r

            // calcul de volumes et aire

            aire = 4 * pi * rcarre; // calcul l'air d'une sphere
            volume = 4d / 3 * pi * rcube; // calcul le volume de la sphere

            //limitation apres la virgule
            double vair = Math.Round(aire, 3);
            double vvolume = Math.Round(volume, 3);

            //affichage

            Console.WriteLine(" ");
            Console.Write("L'air de la sphere est : "+ vair);
            Console.WriteLine(" ");
            Console.WriteLine("Le volume de la sphere est : " + vvolume);
            Console.WriteLine(" ");
            Console.WriteLine(" fin ");

            // attente de saisie fermeture fenetre 
            Console.ReadLine();
        }
    }
}
