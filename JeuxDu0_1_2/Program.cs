using System;

namespace JeuxDu0_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int nombre;
            int scoreUser=0, scoreOrdi=0;
            string userInputa;

            Random aleatoire = new Random();
            int n = aleatoire.Next(0, 2); // nombre aleatoire de l'ordi
            int Nbcoup = 1;

            //saisie
            Console.WriteLine("------ Jeux du 0_1_2 -------");
            do
            {
                Console.Write(" Manche " + Nbcoup);
                Console.WriteLine(" ");
                Console.Write(" Entrez un nombre entre 0 et 2 : ");
                userInputa = Console.ReadLine();

                bool result = Int32.TryParse(userInputa, out nombre);

                if (result)
                {
                    nombre = Convert.ToInt16(userInputa);
                    if (nombre < 0 || nombre > 2)
                        Console.WriteLine("Tu n'as pas rentre 0, 1 ou 2");

                    else if ((nombre-n) == 0)
                    {
                        scoreUser = 0;
                        scoreOrdi = 0;
                    }

                    else if ((nombre-n) == 1)
                    {
                        if (nombre < n)
                        {
                            scoreUser = 1;
                            scoreOrdi = 0;
                        }
                        else
                        {
                            scoreUser = 0;
                            scoreOrdi = 1;
                        }                            
                    }

                    else if ((nombre-n) == 2)
                    {
                        if (nombre > n)
                        {
                            scoreUser = 1;
                            scoreOrdi = 0;
                        }
                        else
                        {
                            scoreUser = 0;
                            scoreOrdi = 1;
                        }
                    }                    

                }
                else
                {
                    Console.WriteLine("Les lettre ne sont pas accepte recommence ");
                }

                // affichage du score
                Console.WriteLine("score User " + scoreUser);
                Console.WriteLine("score User " + scoreOrdi);


                Nbcoup++;
            } while (Nbcoup != 11);


            //affichage
            Console.Write("L'ordinateur a gagner ");
            Console.WriteLine("Bravo tu as gagne ");

            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
