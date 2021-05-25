using System;

namespace Bicyclette
{
    class Program
    {
                    // methode de controle de la question, si autre que oui/non
        public static bool Question (string _MessageDeLaQuestion)
        {
            //variable
            bool resultat =false;            
            string reponse;

            //boucle 
            do
            {
                
                Console.Write(_MessageDeLaQuestion + " oui/non ? ");
                reponse = Console.ReadLine();

            } while (reponse != "oui" && reponse != "non");
            if (reponse=="oui")
            {
                resultat = true;
            }
            return resultat;
        }

                    // methode afficher balade à bicyclette
        public static void BaladeABicyclette ()
        {
            Console.WriteLine("je vais faire une balade à bicyclette");
        }

                    // methode afficher lecture fauteuil confortable
        public static void LectureFauteuil()
        {
            Console.WriteLine("je lis dans mon fauteuil confortable");
        }

        static void Main(string[] args)
        {
            //variable
            string titre = "Activite suivante le temps";

            //affichage
            Console.WriteLine(titre);
            Console.WriteLine(" ");



            //saisie
            bool reponseTmp= Question("Fait_il beau");

            // ----------- traitement s'il fait beau temps
            if (reponseTmp == true) //        if (reponse)
            {
                bool reponseBicyclette = Question("Est-ce que la bicyclette fonctionne bien");

                if (reponseBicyclette == false)
                {
                    bool reponsegarage = Question("Peut-elle être réparer rapidement");
                    if (reponsegarage == false)
                    {
                        Console.Write( " Je vais me balader à pied à l'étang pour ceuillir les joncs");
                    }
                    else
                    {
                        BaladeABicyclette();
                    }
                }
                else
                {
                    BaladeABicyclette();
                }

               
            }
                       // ----------- traitement s'il fait moche
            else   // if (reponse== false)
            {
                bool reponseDispoMaBiblo = Question("Est-ce que Mme Bovary est disponible dans ma bibliotheque");

                if (reponseDispoMaBiblo == false)
                {
                    bool reponseDispoBibloMunicipal = Question("Mme Bovary est-il disponible à la bibliotheque Municipale");
                    if (reponseDispoBibloMunicipal == false)
                    {
                        Console.Write(" J'emprunte un policier");
                        LectureFauteuil();
                    }
                    else
                    {
                        LectureFauteuil();
                    }
                }
                else
                {
                    LectureFauteuil();
                }


            }

            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
           
        }
    }
}
