namespace Delegates.classes;

public class Calculadora
{
    public static int Somar(int a, int b) => a + b;
    public static int Subtrair(int a, int b) => a - b;
    public static int Multiplicar(int a, int b) => a * b;

    public static double Dividir(int a, int b) =>
        b != 0 ? (double)a / b : throw new DivideByZeroException("Não é possível dividir por zero.");
}