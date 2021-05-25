using System;

namespace JeuxDu0_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int nombreJoueur;
            int scoreUser = 0, scoreOrdi = 0;
            string userInputa;

            Random aleatoire = new Random();
            

            //saisie
            Console.WriteLine("------ Jeux du 0_1_2 -------");


            do
            {

                Console.WriteLine(" ");
                Console.Write("Entrez un nombre entre 0 et 2 (un autre nombre pour arreter) : ");
                userInputa = Console.ReadLine();

                bool result = Int32.TryParse(userInputa, out nombreJoueur);
                int ordi = aleatoire.Next(0, 3); // nombre aleatoire de l'ordi


                if (result)
                {
                    
                    nombreJoueur = Convert.ToInt16(userInputa);
                    if (nombreJoueur < 0 || nombreJoueur > 2)
                    {
                        Console.WriteLine("Tu n'as pas rentre 0, 1 ou 2 programme arrete");
                        return;
                    }

                    else if (Math.Abs(nombreJoueur - ordi) == 1)
                    {
                        if (nombreJoueur < ordi)
                        {
                            scoreUser++;
                        }
                        else
                        {
                            scoreOrdi++;
                        }
                        
                        //Console.WriteLine();
                        //Console.WriteLine("difference entre (nombreJoueur - ordi) = " + (Math.Abs(nombreJoueur - ordi)));

                    }

                    else if (Math.Abs(nombreJoueur - ordi) == 2)
                    {
                        if (nombreJoueur > ordi)
                        {
                            scoreUser++;
                        }
                        else
                        {
                            scoreOrdi++;
                        }
                        
                        //Console.WriteLine();
                        //Console.WriteLine("difference entre (nombreJoueur - ordi) = " + (Math.Abs(nombreJoueur - ordi)));

                    }                    

                    //Console.WriteLine();
                    //Console.WriteLine("le nombreJoueur = " + nombreJoueur + "  le nombre ordi = " + ordi);
                }
                else
                {
                    Console.WriteLine("Les lettre ne sont pas accepte recommence ");
                }

                //affichage resultat
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("score User = " + scoreUser + " score ordi = " + scoreOrdi);
                Console.WriteLine();


            } while (scoreUser != 10 && scoreOrdi != 10); 

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
