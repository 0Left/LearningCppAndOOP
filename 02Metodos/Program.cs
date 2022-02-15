
//Dotnet New Console cria o programinha do console

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //Todo projeto tem um desses, e obrigatoriamente deve ter um desses.
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Pessoa nomeGenerico = new Pessoa();
            //Usando o mesmo metódo, de maneiras diferentes
            nomeGenerico.apresentar();
            nomeGenerico.apresentar("Fuen");
            nomeGenerico.apresentar("Left",10);
        }
    }
}