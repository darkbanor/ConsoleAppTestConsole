using System;

namespace Classement
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable a et b
            double a = 3.8;
            double b = 3.6;

            // condition
            if (a<b)
            {
                Console.WriteLine("Ordre croissant");
                Console.WriteLine(" a= "+a+" b="+b);
            }
            else
            {
                Console.WriteLine("Ordre croissant");
                Console.WriteLine("b= " + b + " a=  " + a);
            }
           
            // attente de saisie fermeture fenetre 
            Console.ReadLine();
        }
    }
}
