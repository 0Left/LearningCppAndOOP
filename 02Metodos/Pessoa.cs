//Classe = nome do arquivo 
class Pessoa
{

    //Metodos podem ter nomes iguais, mas precisam ter parametros diferentes
    //Costumo chamar os parametros de assinatura, facilita isso na minha cabeça
    //Podemos ter o mesmo nome mas não a mesma assinatura
    //M01
    public void apresentar()
    {
        Console.WriteLine("Olá!");
    }
    //M02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá! " + nome);

    }
    //M03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá! " + nome + " Você tem: " + idade);

    }

}