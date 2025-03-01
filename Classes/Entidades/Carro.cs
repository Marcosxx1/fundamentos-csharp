namespace Classes.Entidades;

public class Carro
{
    private string modelo { get; set; }
    private string montadora { get; set; }
    private string marca { get; set; }
    private int ano { get; set; }
    private int potencia { get; set; }

    public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        modelo = Modelo;
        montadora = Montadora;
        marca = Marca;
        ano = Ano;
        potencia = Potencia;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    public double VelocidadeMaxima(int potencia)
    {
        
        
        
        
        
        
        return potencia * 1.75;
    }

    public string Modelo => modelo;
    public string Montadora => montadora;
    public string Marca => marca;
    public int Ano => ano;
    public int Potencia => potencia;


    public override string ToString()
    {
        return $"Modelo: {modelo}, Montadora: {montadora}, Marca: {marca}, Ano: {ano}, Potência: {potencia} HP";
    }
}