using System;

namespace LettreChaineCarc
{
    class Program
    {
        static void Main(string[] args)
        {
            //nettoie console
            Console.Clear();

            //variable
            int compt = 0;
            string phrase;
            char lettre;

            //saisie
            Console.Write("Entrez une phrase : ");
            phrase = Console.ReadLine();

            
            if (phrase == "")
            {
                Console.WriteLine("La phrase est vide");
               
            }
            else if (phrase[0] == '.')
            {
                Console.WriteLine("La chaine est vide");                
            }
            else
            { 
                Console.Write("Quel lettre voulez vous rechercher ? : ");
                lettre = char.Parse(Console.ReadLine());

                //traitement
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (phrase[i] == lettre)
                    {
                        compt++;
                    }
                    
                }
                //affichage du resultat
                if (compt == 0)
                {
                    Console.WriteLine("La lettre n'est pas présente");
                }
                else
                {
                    Console.WriteLine("La lettre {0} est présente plusieurs fois", lettre);
                    Console.WriteLine("Il y a {0} {1}", compt, lettre);
                }

            }    

            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
           
        }
    }
}
