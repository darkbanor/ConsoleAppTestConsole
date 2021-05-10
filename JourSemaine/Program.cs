using System;

namespace JourSemaine
{
    class Program
    {
        /// <summary>
        /// Programm pour calculer le jour de la semaine (tableau sur papier)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //titre
            Console.WriteLine(" Calcul du Jour de la semaine");
            Console.WriteLine(" ");

            //variable         
            int jour, mois, annee, resultat4, valeurMois, reste7;

            // valeur moisassignation tableau
            int janvier, fevrier, mars = 4, avril = 0, mai = 2, juin = 5, juillet = 0, aout = 3, septembre = 6, octobre = 1, novembre = 4, decembre = 6;

            
            // saisie + convertion du string en valeur int
            Console.Write(" Calcul du Jour de la semaine format jj/mm/aa ");
            jour = int.Parse(Console.ReadLine());
            Console.Write("/");
            mois = int.Parse(Console.ReadLine());
            Console.Write("/ ");
            annee = int.Parse(Console.ReadLine());

            // annee bissextiles pour janvier fevrier
            resultat4 = (annee + 1900) % 4;
            if (resultat4 % 4 == 0)
            {
                janvier = 0;
                fevrier = 3; 
            }
            else
            {
                janvier = 1;
                fevrier = 4; 
            }   
            
            // valuer du mois associe a mois dans le tableau

            if (mois == 1)
            {
                valeurMois = janvier;
            }

            if (mois == 2)
            {
                valeurMois = fevrier;
            }

            if (mois == 3)
            {
                valeurMois = mars;
            }

            if (mois == 4)
            {
                valeurMois = avril;
            }

            if (mois == 5)
            {
                valeurMois = mai;
            }

            if (mois == 6)
            {
                valeurMois = juin;
            }

            if (mois == 7)
            {
                valeurMois = juillet;
            }

            if (mois == 8)
            {
                valeurMois = aout:            
            }

            if (mois == 9)
            {
                valeurMois = septembre;
            }

            if (mois == 10)
            {
                valeurMois = octobre;
            }

            if (mois == 11)
            {
                valeurMois = novembre;
            }

            if (mois == 12)
            {
                valeurMois = decembre;
            }



            // calcul reste7
            reste7 = (((annee + 1900) + resultat4 + valeurMois + jour) % 7);

            // calcul du jour de la semaine
            
            if (reste7 == 1)
            {
                valeurMois = janvier;
            }

            if (mois == 2)
            {
                valeurMois = fevrier;
            }

            if (mois == 3)
            {
                valeurMois = mars;
            }

            if (mois == 4)
            {
                valeurMois = avril;
            }

            if (mois == 5)
            {
                valeurMois = mai;
            }

            if (mois == 6)
            {
                valeurMois = juin;
            }

            if (mois == 7)
            {
                valeurMois = juillet;
            }






            Console.WriteLine("Hello World!");
        }

       

    }
}
