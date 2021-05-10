using System;

namespace Methode_learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            BonjourPlus("olivier");

            

            Console.WriteLine(SurfaceRec(4, 45));

           

        }

        public static void DireCoucou(string prenom)
        {
            Console.WriteLine("------------");
            Console.WriteLine("Coucou " + prenom);
            Console.WriteLine("------------");
        }

        public static void BonjourPlus(string prenom)
        {
            DireCoucou(prenom);
        }

        public static int SurfaceRec(int largeur, int hauteur)
        {

            Console.Write("La surface du rectangle est ");
            return largeur * hauteur;
        }
    }
}
