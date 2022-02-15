class Aluno 
{
    //Atributos
    public string? nome;
    public double nota1,nota2;

    //Metodos

        // Média
    public double media()
    {
        //Parece mais certinho, n sei pq, ter uma ali pra ter um "intermediario"
        double justReturn = (nota1+nota2)/2;
        return justReturn;
    }
        // Situação
    public string situacao(double media)
    {
        //Operador Ternario
        //Sabia que existia mas n sabia usar, bom saber o nome pra aprender
        //Ternario
        return media >= 7 ? "Aprovado" : "Reprovado";
    }
        // Mensagem
    public void mensagem()
    {
        // Pega valor de média
        double obterMedia = media();
        //Pega situação
        string obterSituacao = situacao(obterMedia);
        //Manda msg
        Console.WriteLine(nome +" está " + obterSituacao+" com média "+ obterMedia);
    }
}