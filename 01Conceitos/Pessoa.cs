//classe? //Molde //Generico
//Classe é tipo uma forma universal, posso estar falando merda mas acho que
//vou usar classe pra tudo, tudo é classe, de uma certa forma, vamos lá.
class Pessoa
{
    //Atributos //Caracteristicas
    //public = Qualquer arquivo pode acessar
    //private = Apenas dentro da classe
    public string? nome;
    public int idade;

    // Métodos //Ação(ões)
    // Escopo TipoDeRetorno Func(Parametros)
    public void mensagem()
    {
        Console.WriteLine("Olá "+nome+" Você tem " +idade+ " anos");
    }
}