using System;

namespace ClassementABC_sansFonc
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            string userInputa; // variable pour la saisie a
            string userInputb; // variable pour la saisie b
            string userInputc; // variable pour la saisie c

            double a;
            //string avalue = "a";
            double b;
            //double bfix = b;
            double c;
            //double cfix = c;
            double tmp;

            //saisie
            Console.WriteLine("Classement ordre croissant ");
            Console.WriteLine(" ");
            Console.Write("Entre un nombre pour le a : ");
            userInputa = Console.ReadLine();
            Console.Write("Entre un nombre pour le b : ");
            userInputb = Console.ReadLine();
            Console.Write("Entre un nombre pour le c : ");
            userInputc = Console.ReadLine();

            // convertion du string en valeur int
            a = Convert.ToDouble(userInputa);
            b = Convert.ToDouble(userInputb);
            c = Convert.ToDouble(userInputc);

            // affichage avant classement
            Console.WriteLine(" ");
            Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
            
            //Calcul
            if (a > b)
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            if (b > c)
            {
                tmp = c;
                c = b;
                b = tmp;
            }
            if (a > b)
            {
                tmp = b;
                b = a;
                a = tmp;
            }

            //affichage

            Console.WriteLine(" ");
            Console.WriteLine("classement = "+a+"  "+b+"  "+c);
            //Console.WriteLine("classement = " + afix + "  " + bfix + "  " + cfix);

            // attente de saisie fermeture fenetre 
            Console.ReadLine();
        }
    }
}
