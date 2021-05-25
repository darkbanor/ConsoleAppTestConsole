using System;

namespace lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            string texte = @" Nous étions à l'Étude, quand le Proviseur entra, suivi d'un nouveau habillé /n
                en bourgeois et d'un garçon de classe qui portait un grand pupitre. \n
                Ceux qui dormaient se réveillèrent, et chacun se leva comme surpris dans son travail.\n
                Le Proviseur nous fit signe de nous rasseoir; puis, se tournant vers le maître d'études :\n
                Monsieur Roger, lui dit - il à demi-voix, voici un élève que je vous recommande,\n
                il entre en cinquième.";

            string titre = "Madame Bovary texte";
            string rep="";

            //affichage

            Console.WriteLine(titre);
            Console.WriteLine(" ");
            Console.WriteLine(texte); 
            Console.WriteLine(" ");

            //saisie
            do
            {
                Console.Write("Avez vous compris ? (oui/non) ");
                rep = Console.ReadLine();

            }while (rep != "oui" && rep != "non");

            //while (rep !="non" && rep != "oui");



            if (rep == "non" )
            {
                Console.WriteLine("relisez attentivement !");
                Console.WriteLine(" ");
                Console.WriteLine(texte);
                Console.WriteLine(" ");

                do
                {
                    Console.Write("Avez vous compris ? (oui/non) ");
                    rep = Console.ReadLine();

                } while (rep != "oui" && rep != "non");

                if (rep == "non")
                {
                   Console.WriteLine("Demander des info supplémentaire au formateur !! ");
                }

            } 

            Console.WriteLine(" ");
            Console.WriteLine("ecrire speudo code");
            Console.WriteLine("vérification du speudo code");
            Console.WriteLine("ecriture programme");
            Console.WriteLine("tester le programme");
            Console.ReadLine();


        }
    }
}
