namespace Heranca_modifAcesso;

public class ClasseDerivada : ClasseBase
{
    public void Acessar()
    {
        MembroPublico();
        MembroProtegido();
        MembroInterno();
        MembroProtegidoInterno();
        //MembroPrivado() Não é possível 

        var soma = public_var + protected_var + internal_var + private_var;
    }
}

public class ClasseBase
{
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    public int _privateVar = 4;

    public int private_var
    {
        get { return _privateVar; }
        set { _privateVar = value; }
    }

    public void MembroPublico()
    {
        Console.WriteLine("Classe Base - Método público");
    }

    protected void MembroProtegido()
    {
        Console.WriteLine("Classe Base - Método protegido");
    }

    internal void MembroInterno()
    {
        Console.WriteLine("Classe Base - Método interno");
    }

    protected internal void MembroProtegidoInterno()
    {
        Console.WriteLine("Classe Base - Método protegido interno");
    }

    private void MembroPrivado()
    {
        Console.WriteLine("Classe Base - Método privado");
    }
}