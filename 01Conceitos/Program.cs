//Using é tipo um import, e eu digo de onde to importanto
//using System;

//nameSpace é o nome do espaço que aquilo ta dentro
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //Todo projeto tem um desses, e obrigatoriamente deve ter um desses.
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = "Left";
            obj.idade = 22;
            obj.mensagem();

        }
    }
}


// or
// Console.WriteLine("Hello, World!");