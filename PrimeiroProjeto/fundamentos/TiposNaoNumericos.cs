namespace fundamentos;

public class TiposNaoNumericos
{
    public void MostraNaoNumericos()
    {
        /*Tipos não numéricos
         - bool
         - char

         - São tipos de valor armazenados na stack
         - O tipo 'bool' pode ser obtido como resultado de operações de comparação e de igualdade
         - O valor padrão do tipo bool é 'false'
         - O valor padrão do tipo char é '\O' (U+0000) - representação unicode para 'NUL'
         */

        bool ativo = true;
        System.Boolean inativo = false;

        Console.WriteLine(ativo);
        Console.WriteLine(inativo);

        char charLetraA = 'a';
        System.Char charLetraB = 'b';
        
        
        Console.WriteLine("Tipos não numéricos");

        Console.WriteLine(ativo.GetType());
        Console.WriteLine($"15 == 10: {15 == 10}");
        Console.WriteLine($"15 != 10: {15 != 10}");
        Console.WriteLine($"15 > 10: {15 > 10}");
        Console.WriteLine($"15 < 10: {15 < 10}");
        
        Console.WriteLine(charLetraA);
        Console.WriteLine(charLetraB);
        Console.WriteLine();
    }
}