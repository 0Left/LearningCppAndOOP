//classe? //Molde //Generico
class Pessoa
{
    //Atributos //Caracteristicas
    //public = Qualquer arquivo pode acessar
    //private = Apenas esse arquivo ou apenas essa classe?
    public string? nome;
    public int idade;

    // Métodos //Ação(ões)
    // Escopo TipoDeRetorno Func(Parametros)
    public void mensagem()
    {
        Console.WriteLine("Olá "+nome+" Você tem " +idade+ " anos");
    }
}