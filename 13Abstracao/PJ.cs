using System;
class PJ : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa para Pessoa Juridica R$" +(valor*0.2));
    }
}