namespace Classes.Entidades;

public class Aluno
{
    // Quando não definimos um construtor padrão, o C# define um publico sem argumentos
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    // Mas também podemos criar um construtor 
    // Mas ao criar um construtor costumizado, não teremos acesso ao criado pelo c#
    // mas podemos criar um sem parametros também

    public Aluno(string nome) => Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
}