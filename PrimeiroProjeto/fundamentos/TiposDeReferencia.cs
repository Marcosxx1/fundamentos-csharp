using fundamentos.entidades;

namespace fundamentos;

public class TiposDeReferencia
{
    /*Tipso de referência:
     - São tipos de referência
     - O valor padrão é null
     - São classes, objetos, interfaces, delegate, arrays
     - São tipos complexos
     - São tipos de valor

     */
    public void mostraTiposDeReferencia()
    {
        Usuario usuario = new Usuario("Marcos", "marcos@email.com", "senhaSuperForte");
        Console.WriteLine($"Nome do usuário: {usuario.Nome}");
        Console.WriteLine($"Email do usuário: {usuario.Email}");
        Console.WriteLine($"Senha do usuário: {usuario.Senha}");

        //arrays
        // int[] numeros = new int[] {1,2,3 };
        int[] numeros = { 1, 2, 3 };

        foreach(var numero in numeros)
        {
            
            Console.WriteLine(numero);
        }

        Console.WriteLine();
        
        /*strings
         Uma vez declarada, a variável do tipo string não pode ser alterada*/
        string nome = "Marcos";
        System.String anotacaoDotNet = "String utilizando notaçãoDotNet";
    }
}