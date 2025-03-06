using ListCollection.listExample;

namespace ListCollection;

class Program
{
    static void Main(string[] args)
    {
        ListExampleCode LE = new ListExampleCode();

        List<string> valores = new List<string>() { "batata", "biscoito" };
        LE.AdicionaUmElementoComAdd("Marcos2"); //  Usado .Add()
        LE.AdicionaUmElementoComInsert(3,
            "Marcos2"); //  Usado .Insert(int,string) que coloca um valor em um indice específico

        LE.AdicionarVariosElementos(valores); // Usando .AddRange()
        LE.AdicionarVariosElementosInsertRange(1, valores); // Usando .AddRange()

        LE.ImprimeLista();
        LE.ImprimeListaVariados();

        LE.IniciaListaDeNomesVariados();
        string valor = LE.EncontraPorOcorrenciaDeLetra("A");
        Console.WriteLine($"Nome encontrado: {valor}");

        List<string> valoresEncontrados = LE.EncontraTodasOcorrencias("o");
        foreach (var valorE in valoresEncontrados)
        {
            Console.WriteLine($"{valorE}");
        }

 
    }
}