using Arrays.classes;

namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        ArraysEx arrays = new ArraysEx();

        //arrays.ForNormal();
        //arrays.MostraNomes();

        int[] intArray = new[] { 1, 6, 8, 44, 33, 345, 734, 21, 24, 827, 12 };

        Console.WriteLine("Array Invertido");
        Array.Reverse(intArray);
        MostraArray(intArray);

        Console.WriteLine("\nArray ordenado");
        Array.Sort(intArray);
        MostraArray(intArray);

        Console.WriteLine("\nBusca Binária");
        int valorABuscar = 33;
        var indice = Array.BinarySearch(intArray, valorABuscar);
        Console.WriteLine(indice);

    }

    static void MostraArray(int[] array)
    {
        foreach (var value in array)
        {
            Console.WriteLine($"{value}");
        }
    }
}