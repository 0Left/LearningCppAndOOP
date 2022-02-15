class Pessoa
{
    //Atributos
    public double peso;
    public double altura;

    //Metodo
    public double CalculoIMC()
    {
        return peso / (altura * altura);
    }
    public void mensagem()
    {
        Double BodyIMC = CalculoIMC();
        String toReturn;
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
        Console.WriteLine("Seu IMC atual é: " + BodyIMC + " você se encontra na faixa: " + toReturn);
        return;
    }

}