namespace Classes.Entidades;

public class Pessoa
{
    public string Nome;
    public string Sobrenome;
    public DateTime Idade;

    public void Saudacao()
    {
        Console.WriteLine($"Olá sou {Nome}");
        ExibirDataAtual();
    }

    public void ExibirDataAtual() => Console.WriteLine($"Hoje é : {DateTime.Now}");

    //Parametros
    public String CalculaSoma(float primeiro, float segundo)
    {
        var soma = primeiro + segundo;
        return $"A soma é: {soma}";
    }
}