using System;

namespace BarnabeCourse
{
    class Program
    {

        static void Main(string[] args)
        {
            //variable
            double somme; //sommes de départ  
            double somfixe;
            double depense;
            double reste;
            int nbMagasin = 0;


            //saisie du nombre   
            Console.Write(" Entrez un nombre superieur à zéro: ");
            somme = int.Parse(Console.ReadLine());
            somfixe = somme; // fixe la somme avant changement

            // calcul 
            while (somme > 2)
            {
                //Console.WriteLine(" somme : " + somme); //test

                depense = ((somme / 2) + 1);

                //onsole.WriteLine(" depense : " + depense); //test

                reste = somme - depense;

                //Console.WriteLine(" reste : " + reste);  //test

                somme = reste;

                //Console.WriteLine(" new somme : " + somme);  //test

                nbMagasin++;

                //Console.WriteLine(" Nombre magasins : " + nbMagasin);  //test

            }
            // vidage de la somme
            if (somme >= 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine(String.Format("il me reste {0:0.00} ", somme) + " a dépenser dans un magasins");
                nbMagasin = nbMagasin + 1;
            }

            // affichage resultats
            Console.WriteLine(" ");
            Console.WriteLine("pour la somme de " + somfixe + " vous avez visitez " + nbMagasin + " magasins");


            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
        }
    }
}
