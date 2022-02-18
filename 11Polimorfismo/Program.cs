using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            //Polimorfizando o Imposto
            Imposto objE = new Estagiario();
            objE.valeAlimentacao(1000);
            objE.valeTransporte(1000);
            Console.WriteLine("-------------");
            
            Imposto objG = new Gerente();
            objG.valeAlimentacao(5000);
            objG.valeTransporte(5000);
            Console.WriteLine("-------------");
            
            Imposto objA = new Atendente();
            objA.valeAlimentacao(2000);
            objA.valeTransporte(2000);
            Console.WriteLine("-------------");
            
            Imposto objI = new Imposto();
            objI.valeAlimentacao(10000);
            objI.valeTransporte(10000);
            Console.WriteLine("-------------");

        }
    }
}