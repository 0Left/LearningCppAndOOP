class Pessoa
{
    //Atributos
    public double peso,altura;

    //Metodo
    public double calculoIMC()
    {
        return peso / (altura * altura);
    }
    public string situation(Double BodyIMC)
    {
        string toReturn;
        if (BodyIMC < 18.5)
        {
            toReturn = "Abaixo do peso";
        }
        else if(BodyIMC < 25)
        {
            toReturn = "Peso normal";
        }
        else if(BodyIMC < 30)
        {
            toReturn = "Acima do peso";
        }
        else if(BodyIMC < 35)
        {
            toReturn = "Obesidade I";
        }
        else if(BodyIMC < 40)
        {
            toReturn = "Obesidade II";
        }
        else {
            toReturn = "Obesidade III";
        }
        return toReturn;
    }
    public void mensagem(){
        double BodyIMC = calculoIMC();
        string situacao = situation(BodyIMC);
        Console.WriteLine("Seu IMC atual é: " + BodyIMC + " você se encontra na faixa: " + situacao);
    }
}