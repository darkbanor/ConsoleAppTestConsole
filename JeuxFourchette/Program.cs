using System;

namespace JeuxFourchette
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int nombre;
            string userInputa;
            
            Random aleatoire = new Random ();
            int mystere = aleatoire.Next(0, 100);
            int Nbcoup=0;

            //saisie
            Console.WriteLine("------ Jeux de la Fourchette : trouver le nombre inconnu -------");
            do
            {
                Console.Write(" Entrez un nombre entre 0 et 100 : ");
                userInputa = Console.ReadLine();
                
                bool result = Int32.TryParse(userInputa, out nombre);
                
                if (result)
                {
                    nombre = Convert.ToInt16(userInputa);
                    if (nombre <= 0 || nombre >= 100)
                        Console.WriteLine("Nombre entre 0 et 100 !! tu as perdu " + Nbcoup + " coups");
                    else if (nombre < mystere)
                    {
                        Console.WriteLine("trop petit");
                    }
                    else if (nombre > mystere)
                    {
                        Console.WriteLine("trop grand");
                    }

                    
                }
                else
                {
                    Console.WriteLine("Les lettre ne sont pas accepte tu as perdu " + Nbcoup + " coups");
                }

                Nbcoup++;
            } while (nombre != mystere);
            
            
            //affichage
            Console.WriteLine("Bravo tu as gagne en " + Nbcoup + " coups");

            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
        }
    }
}
