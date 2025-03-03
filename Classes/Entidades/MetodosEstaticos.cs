namespace Classes.Entidades;

public class MetodosEstaticos
{
    public static void  DizOla()
    {
        Console.WriteLine("Olá");
    }
    
    public static void  DizOla(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

    public static double SomaDoisNumeros(double primeiro, double segundo)
    {
        return primeiro + segundo;
    }
} 