namespace Structs.entidade;

public struct Cliente
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    private int idade;

    public int Idade
    {
        get { return idade; }
        set { idade = value < 18 ? 18 : value; }
    }

    public Cliente(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public static void ExibirInfo(string nome, string email, int? idade = null)
    {
        if (idade.HasValue)
        {
            Console.WriteLine($"O nome é: {nome}, e-mail é: {email} e idade é {idade}");
        }
        else
        {
            Console.WriteLine($"O nome é: {nome}, e-mail é: {email}");
        }
    }
}