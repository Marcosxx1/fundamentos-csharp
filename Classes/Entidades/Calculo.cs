 namespace Classes.Entidades;

public class Calculo
{
    public void Dobrar(ref int y)
    {
         y *= 2;
         Console.WriteLine($"O valor dobrado é {y}");
    }

    public double CalcularAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}