using System;
class Pessoa
{
    private string? nome;
    public Pessoa(string nome){
        Console.WriteLine("Olá " + nome);
        Console.WriteLine("Olá " + this.nome);
    }
}