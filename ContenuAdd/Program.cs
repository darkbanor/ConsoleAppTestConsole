using System;

namespace ContenuAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //valeur de a et de b
            int a=5;
            int b=8;
            int c=a;

            // lire valeur a
            Console.WriteLine("Valeur de a : "+a);

            // lire valeur b
            Console.WriteLine("Valeur de a : " +b);

            //transfert valeur
            a = b;
            b = c;

            //affichage a dans b
            Console.WriteLine("nouvelle valeur a : " +a);

            //affichage b dans a
            Console.WriteLine("nouvelle valeur b : " +b);

        }
    }
}
