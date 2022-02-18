using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Exemplo.soma(20,20);
            Console.WriteLine(Exemplo.iD);
            Exemplo.iD = "Fuen";
            Console.WriteLine(Exemplo.iD);
            Exemplo Obj = new Exemplo();
            Console.WriteLine(Obj.name);
            
        }
    }
}