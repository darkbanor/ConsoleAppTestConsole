using System;

namespace CalculNombreJeunes
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------variable
            int count = 0;

            // ---------------- entree manuel du tableau
            //int[] nombres = new int[] {45, 35, 65, 87, 81, 91, 45, 99, 41, 87, 78, 54, 68, 58, 72, 22, 69, 56, 25, 66}; //que + 20
            int[] nombres = new int[] { 15, 5, 5, 7, 1, 9, 14, 19, 11, 8, 17, 13, 16, 19, 18, 17, 6, 12, 6, 3 }; //que -20
            //int[] nombres = new int[] { 15, 5, 5, 7, 1, 9, 14, 19, 11, 48, 47, 23, 26, 39, 48, 57, 66, 21, 69, 35 }; // 9 mois de 20



            // ------------saisie des 20 ages

            //int age;
            //int tab = 0;
            // int[] nombres = new int [20]; -- pour saisie par utilisateur

            /*do
            {
                
                Console.Write(" Entrez l'age de la personne " + (tab+1) + " : ");
                age = int.Parse(Console.ReadLine());
                 nombres [tab] = age;

                tab++;

            } while (tab <= 0 || tab <= 19);

            */



            // ------------------traitement du tableau

            Console.WriteLine("nombre = ");

            for (int i = 0; i < nombres.Length; i++)
            {

                //Console.Write(nombres[i] + " - ");
                Console.Write(" {0} - ", nombres[i]);

                if (nombres[i] < 20)
                {
                    count++;
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
           
            if (count == 20)
            {
                Console.WriteLine("Toutes les personnes ont moins de 20 ans");
            }
            else if (count == 0)
            {
                Console.WriteLine("Toutes les personnes ont plus de 20 ans");
            }
            else // if (count != 0 || count != 20)
            {
                Console.WriteLine("il y a " + count + " personnes moins de 20 ans et " + (20 - count) + " personnes plus de 20 ans");
            }

            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
        }
    }
}
