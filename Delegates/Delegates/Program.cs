using Delegates.classes;


// Delegate that uses Calculadora.Somar()
public delegate int Operacao(int a, int b);

internal class Program
{
    public static void Main(string[] args)
    {
        Operacao op = Calculadora.Somar;
        int resultado = op(10, 20);
        Console.WriteLine($"Soma: {resultado}");
        
        op = Calculadora.Subtrair;
        resultado = op(10, 20);
        Console.WriteLine($"Subtração: {resultado}");
    }
}