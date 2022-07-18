using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Qual tabuada: ");
            int tab = Convert.ToInt32(Console.ReadLine());
            
         
               for (int b = 2; b < 10; b++)
                {
                    Console.WriteLine(tab + "x" + b + "=" + tab * b);
                }
               Console.ReadLine();
        } 





        
    }
}
