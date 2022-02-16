class Pessoa
{
    public Pessoa()
    {
        nomeUsuario = "Waiting for a name...";
    }
    private string nomeUsuario;
    public string Nome
    {
        get{return nomeUsuario;}
        set{nomeUsuario = value;}
    }

}