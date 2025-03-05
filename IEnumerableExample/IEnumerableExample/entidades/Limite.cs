 
public class Limite
{
    private int _numero;

    public int Numero
    {
        get => _numero;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "O número não pode ser negativo");
            _numero = value;
        }
    }

    private bool _isRestricao;

    public bool IsRestricao
    {
        get => _isRestricao;
        set => _isRestricao = value;
    }

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        IsRestricao = numeroAleatorio == 1;
    }

    public bool AnalisaLimite()
    {
        Console.WriteLine($"Análise de limite de crédito para o limite: {Numero}");
        return IsRestricao;
    }
}