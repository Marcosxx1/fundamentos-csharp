namespace Heranca_modifAcesso.BaseHeranca;

public class Pessoa
{
    public string Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
    
    public virtual void Apresentar()
    {
        Console.WriteLine("Olá, eu sou uma pessoa.");
    }
}

public class Aluno : Pessoa
{
    public int Matricula { get; set; }

    public Aluno(string nome, int matricula) : base(nome) // Chama o construtor da classe base
    {
        Matricula = matricula;
    }
    
    public override void Apresentar()
    {
        base.Apresentar(); // Chama o método da classe base
        Console.WriteLine("E também sou um aluno.");
    }
}
