using System;

namespace Bissextile
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable         
            int annee;         

           
            //saisie
            Console.WriteLine(" Annee bissextile ");
            Console.WriteLine(" ");
            Console.Write("Entre une annee : ");            

            // convertion du string en valeur int
            annee = Convert.ToInt16(Console.ReadLine());

            //Calcul            

            if (annee % 4 != 0)
            {
                Console.WriteLine(" c'est une annee non bissextile ");
            }
            else
            {
                if (annee % 4 == 0)
                {
                    if (((annee/100) %4 == 0) && ((annee/400) % 4 != 0))
                    {
                        Console.WriteLine(" c'est une annee non bissextile suivant condition ");
                    }
                    else
                    {
                        Console.WriteLine(" c'est une annee bissextile ");
                    }

                }

            }
            // attente de saisie fermeture fenetre 
            
            Console.ReadLine();



        }
    }
}
