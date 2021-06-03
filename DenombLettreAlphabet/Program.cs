using System;

namespace DenombLettreAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            //nettoie console
            Console.Clear();

            //variable
            int compt1 = 0, compt2 = 0;

            string phrase = @"Depuis plusieurs années, je constate que l’écrit est souvent lié à une contrainte et que les élèves ne
             prennent que peu de plaisir à écrire et par conséquent ne progressent que très peu.";

            string alphabet = "abcdefghijklmnpqrstuvxyzàéè.,ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] compteur = new int[alphabet.Length]; 


            //traitement
            for (int i = 0; i < alphabet.Length; i++)
            {
                //compt2 = 1;

                for (int j = 0; j < phrase.Length; j++)
                {
                    

                    if (alphabet[i] == phrase[j])
                    {
                        //mettre a jour la valeur du compteur ds le tableau compteur
                        compteur[i]++;
                            //compt2++;
                        
                    }

                }

            }
            //affichage du resultat
            for (int a=0; a<phrase.Length;a++)
            {
                compt1++;
            }

            Console.WriteLine(phrase);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Il y a {0} lettre dans la phrase ", compt1);
            Console.WriteLine(" ");

            for (int i = 0; i < compteur.Length; i++)
            {
                if (compteur[i] != 0)
                {
                    Console.WriteLine("lettre " + alphabet[i] + " a  " + compteur[i] + " occurrences ");
                }
            }
            
            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
        }
    }
}
