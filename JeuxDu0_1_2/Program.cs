using System;

namespace JeuxDu0_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int NombreJoueur;
            int scoreUser=0, scoreOrdi=0;
            string userInputa;

            Random aleatoire = new Random();
            int ordi = aleatoire.Next(0, 2); // nombre aleatoire de l'ordi
            
            //saisie
            Console.WriteLine("------ Jeux du 0_1_2 -------");


            do
            {

                Console.WriteLine(" ");
                Console.Write(" Entrez un nombre entre 0 et 2 : ");
                userInputa = Console.ReadLine();

                bool result = Int32.TryParse(userInputa, out NombreJoueur);

                if (result)
                {
                    NombreJoueur = Convert.ToInt16(userInputa);
                    if (NombreJoueur < 0 || NombreJoueur > 2)
                        Console.WriteLine("Tu n'as pas rentre 0, 1 ou 2 programme arrete");

                    else if (NombreJoueur > ordi) 
                    {
                        if ((NombreJoueur - ordi) == 1)
                        {                           
                           scoreOrdi++;                           
                        }
                        else if ((NombreJoueur - ordi) == 2)
                        {
                            scoreUser++;
                        }
                    }

                    else if (ordi > NombreJoueur)
                    {
                        if ((ordi - NombreJoueur) == 1)
                        {
                            scoreUser++;
                        }
                        else if ((ordi - NombreJoueur) == 2)
                        {
                            scoreOrdi++;
                        }
                    }

                    //affichage resultat
                    Console.WriteLine("score User = " + scoreUser + " score ordi = " + scoreOrdi);
                    Console.WriteLine("nombreJoueur = " + NombreJoueur + " ordi = " + ordi);
                    Console.WriteLine("nombreJoueur - ordi = " + (NombreJoueur  -ordi));
                    Console.WriteLine("ordi - nombreJoueur " + (ordi - NombreJoueur));

                }
                else
                {
                    Console.WriteLine("Les lettre ne sont pas accepte recommence ");
                }

            } while (scoreUser == 10 && scoreOrdi == 10);


            //affichage
            if (scoreUser == 10)
            {
                Console.WriteLine("Bravo tu as gagne ");
            }
            else
            {
                Console.Write("L'ordinateur a gagner ");
            }

            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();            
        }
        
    }
}
