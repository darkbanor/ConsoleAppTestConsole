using System;

namespace TestCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // valuer du mois associe a mois dans le tableau
            int mois = 0;
            string valeurMois = "";

            // saisie
            //Console.Write(" quel mois ? :");
            //mois = int.Parse(Console.ReadLine());

            do
            {
                Console.Write(" quel mois ? :");
                mois = int.Parse(Console.ReadLine());

                if (mois < 1 || mois >= 12)
                    Console.WriteLine(" entree incorrecte ");

            } while (mois < 1 || mois >= 12);

            switch (mois)
            {
                case 1:
                    valeurMois = "janvier";
                    break;

                case 2:
                    valeurMois = "fevrier";
                    break;

                case 3:
                    valeurMois = "mars";
                    break;

                case 4:
                    valeurMois = "avril";
                    break;

                case 5:
                    valeurMois = "mai";
                    break;

                case 6:
                    valeurMois = "juin";
                    break;

                case 7:
                    valeurMois = "juillet";
                    break;

                case 8:
                    valeurMois = "aout";
                    break;

                case 9:
                    valeurMois = "septembre";
                    break;

                case 10:
                    valeurMois = "octobre";
                    break;

                case 11:
                    valeurMois = "novembre";
                    break;

                case 12:
                    valeurMois = "decembre";
                    break;

                default:
                    throw new Exception("mois incorrect");
            }                   
                    
                    Console.WriteLine("votre mois est : " + valeurMois);
        }
    }
}
