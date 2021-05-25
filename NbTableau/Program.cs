using System;

namespace NbTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nombre = { 1, 45, 8, 15, 88 };           
            int longNombre = nombre.Length;

            Console.WriteLine("votre tableau fait : " + longNombre);
            
            Array.Sort(nombre);
            foreach (int i in nombre)
                {
                Console.Write(" " + i);
                }

            //fin programme
            Console.WriteLine(" ");
            Console.WriteLine("Fin programme");
            Console.ReadLine();
        }
    }
}
