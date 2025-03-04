namespace try_catch;

class Program
{
    static void Main(string[] args)
    {
        int primeiro = 1;
        int segundo = 0;
        int resultado=0;
        try
        {
            resultado = primeiro / segundo;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e);
            Console.WriteLine("Não é possível dividir por zero");
        }
        finally
        {
            Console.WriteLine("Finalmente a divisão foi finalizada");
        }

        Console.WriteLine($"O resultado é: {resultado}");
    }
}