using System;
namespace _14Interface
{
    class Program{

        static void Main(string[] args){
            Calculo c = new Calculo();
            c.somar(1,10);
            c.subtrair(10,1);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("arg:" + args[i]);
                
            }
        }
    }

}