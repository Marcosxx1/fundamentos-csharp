namespace Classes.Entidades;

public class Produto
{
    private string nome;
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value ?? "";  }
    }
    
    public double Preco { get; set; }
    public double Desconto { get; set; }
    public double PrecoFinal { get; set; }
    public int EstoQueMinumo { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n {Preco.ToString("c")}\n {Desconto}" +
                          $"\n{PrecoFinal.ToString("c")}, \n{EstoQueMinumo}");
    }
}