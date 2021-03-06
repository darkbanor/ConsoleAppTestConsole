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
            int jour=0, mois=0, annee=0, janvier = 0, fevrier = 0;
            int resultat4, reste7=0;
            int valeurMois = 0;
            string jourSem = "";
            //pour test
            double divi = 0;

            // valeur moisassignation tableau
            const int mars = 4, avril = 0, mai = 2, juin = 5, juillet = 0, aout = 3, septembre = 6, octobre = 1, novembre = 4, decembre = 6;


            // saisie + convertion du string en valeur int
            Console.WriteLine(" Calcul du Jour de la semaine format (jj/mm/aa) tout en chiffre : ");
            Console.WriteLine(" ");


            // verif  entree date 

            do
            {
                Console.Write(" Entrez le jour : ");
                jour = int.Parse(Console.ReadLine());

                if (jour <= 0 || jour >= 31)
                    Console.WriteLine("Entree incorrecte ");

            } while (jour <= 0 || jour >= 31);

            do
            {
                Console.Write("Entrez le mois : ");
                mois = int.Parse(Console.ReadLine());

                if (mois < 1 || mois >= 12)
                    Console.WriteLine(" entree incorrecte ");

            } while (mois < 1 || mois >= 12);


            do
            {
                Console.Write(" Entrez le annee : ");
                annee = int.Parse(Console.ReadLine());

                if (annee < 0 || annee >= 99)
                    Console.WriteLine(" entree incorrecte ");

            } while (annee < 0 || annee >= 99);

            Console.Write(" ");

            // annee bissextiles pour janvier fevrier
            resultat4 = (annee / 4);



            // valuer du mois associe a mois dans le tableau

           
            if (mois == 1)
            {                    
                     if (annee % 4 == 0)
                     janvier = 0; // bissextile
                     else
                     janvier = 1;
                      
                valeurMois = janvier;
            }
            else if (mois == 2)
            {
                    if (annee % 4 == 0)                   
                    fevrier = 3;  // bissextile             
                    else               
                    fevrier = 4;
               
                valeurMois = fevrier;
            }
            else if (mois == 3)
            {
                valeurMois = mars;
            }
            else if (mois == 4)
            {
                valeurMois = avril;
            }

            else if (mois == 5)
            {
                valeurMois = mai;
            }

            else if (mois == 6)
            {
                valeurMois = juin;
            }

            else if (mois == 7)
            {
                valeurMois = juillet;
            }

            else if (mois == 8)
            {
                valeurMois = aout;
            }

            else if (mois == 9)
            {
                valeurMois = septembre;
            }

            else if (mois == 10)
            {
                valeurMois = octobre;
            }

            else if (mois == 11)
            {
                valeurMois = novembre;
            }

            else if (mois == 12)
            {
                valeurMois = decembre;
            }
        


            // calcul reste7
            reste7 = ((annee + resultat4 + valeurMois + jour) % 7) ;
            //divi = ((annee + resultat4 + valeurMois + jour) / 7) ;
            

            // calcul du jour de la semaine

            if (reste7 == 1)
            {
                jourSem = "dimanche";
            }

            else if (reste7 == 2)
            {
                jourSem = "lundi";
            }

            else if (reste7 == 3)
            {
                jourSem = "mardi";
            }

            else if (reste7 == 4)
            {
                jourSem = "mercredi";
            }

            else if (reste7 == 5)
            {
                jourSem = "jeudi";
            }

            else if (reste7 == 6)
            {
                jourSem = "vendredi";
            }

            else if (reste7 == 0)
            {
                jourSem = "samedi";
            }


            Console.WriteLine(" le jour de la semaine pour la date que vous avez entrez est ");            
            Console.WriteLine(jourSem);

            //debug
            Console.WriteLine(" ------------------------------ debug ------------ ");
            Console.WriteLine("jour= " + jour + " mois=" + mois + " annee=" + annee);
            Console.WriteLine("resultat4= " + resultat4);
            Console.WriteLine("resultat4 % 4= " + (resultat4 % 4));
            Console.WriteLine("valeurMois= " + valeurMois);
            Console.WriteLine("janvier= " + janvier);
            Console.WriteLine("fevrier= " + fevrier);
            Console.WriteLine("reste7= " + reste7);
            Console.WriteLine("division reste7= " + divi);
            Console.WriteLine("joursem= " + jourSem);


            Console.ReadKey();
        }       
       
    }
}
