namespace POO_simplificado.entidades;

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"Nome: {Nome}    -    E-mail: {Email}      -   Classe: {GetType().Name}");
    }
}