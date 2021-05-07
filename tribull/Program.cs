using System;

namespace tribull
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration tableau
            int [] t = new int[10];
            int min=0, max=0, som=0, c=0;
            bool flag = true;

            //remplissage
            Console.WriteLine("Tableau d'entier programme");
            Console.WriteLine("Tapez 10 nombres :");
            for (int i=0; i<10; i++)
            {
                t[i] = Convert.ToInt16(Console.ReadLine());
                if (i == 0)
                {
                    min = t[i]; max = t[i]; som = t[i];
                }
                else 
                {
                    if (t[i] < min) min = t[i];
                    if (t[i] > max) max = t[i];
                    som += t[i];
                }
            }

            //traitement
            do
            {
                flag = true;
                for (int i = 0; i < 9; i++)
                {
                    if (t[i]> t[i]+1)
                    {
                        c = t[i];
                        t[i] = t[i + 1];
                        t[i + 1] = c;
                        flag = false;
                    }
                }

            } while (!flag);

            //affichage
            for (int i = 0; i < 10; i++)
            {
                Console.Write(t[i] + " - \t");
            }
            Console.WriteLine();
            Console.WriteLine("la valeur max est : "+max);
            Console.WriteLine("la valeur minimal est :"+min);
            Console.WriteLine("la moyenne est :" + (som/10));
            Console.WriteLine();
            Console.WriteLine("tapez une touche pour quitter !");
            Console.ReadKey();
        }
    }
}
