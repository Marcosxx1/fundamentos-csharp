namespace Arrays.classes;

public class ArraysEx
{
    public void ForEach()
    {
        //int[] arrayInt = new int[5] { 1, 2, 3, 4, 5 };
        int[] arrayInt = { 1, 2, 3, 4, 5 };

        foreach (int inteiro in arrayInt)
        {
            Console.WriteLine($"{inteiro}");
        }
    }

    public void ForNormal()
    {
        int[] arrayInt = { 1, 23, 32, 4, 8 };
        Array.Sort(arrayInt);
        Console.WriteLine(arrayInt);
        for (int i = 0; i < arrayInt.Length; i++)
        {
            Console.WriteLine($"O índice: {i}, contem o valor: {arrayInt[i]}");
        }
    }

    public void MostraNomes()
    {
        string[] arrayDeNomes = { "Aline", "Marcos", "Fofy" };

        foreach (var nome in arrayDeNomes)
        {
            Console.WriteLine($"Nome: {nome}");
        }
    }

    public void MostraNotas()
    {
        int[] notas = { 1, 23, 32, 4, 8 };

        foreach (var nota in notas)
        {
            Console.WriteLine(nota);
        }

    }
}