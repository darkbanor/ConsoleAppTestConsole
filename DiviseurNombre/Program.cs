using System;

namespace DiviseurNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int nombre;
            bool premier = true;
            int reste;


            //saisie du nombre à determiner si 1er          
            Console.Write(" Entrez le nombre : ");
            nombre = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            //affichage titre
            

            // ------------   calcul et affichage

                    // determiner si c'est premier
            int a = 2;

            while (a < nombre && premier == true)
            {
                reste = nombre % a;

                if (reste == 0)
                {
                    premier = false;
                }

                a++;
            }
            // afficher les diviseurs
            if (premier == false)
            {
                Console.WriteLine("Diviseur de " + nombre);

                for (int i = 2; i < nombre; i++)
                {
                   
                    if (nombre % i == 0)
                    {
                        Console.WriteLine(nombre + "/" + i + "= " + nombre / i);
                    }

                }
            }
            else
            {
                Console.WriteLine("Ce nombre est premier pas de diviseur");
            }

                //fin programme
                Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();           
        
        
        
        }
    }
}
