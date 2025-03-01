namespace fundamentos;

public class TiposNulos
{
    /*Por padrão no C# não podemos a uma variável de tipo o 'valor' null
     - int valor = null; vai nos dar erro 'Cannot convert source type 'null' to target type 'int''
     */

    // Podemos definir com o Nullable<tipo> <nomeVariável> = null;

    private Nullable<int> intNullable = null;
    private Nullable<bool> intBool = null;
    private Nullable<long> intLong = null;

    private int? intNullableEncurtado = null;
    private int? boolNullableEncurtado = null;
    private int? longNullableEncurtado = null;

    /*
     * Nullable Types são diferentes dos tipos por valor
     * o 'Nullable Type int? é diferente do tipo int, ex:
     * Nullable<int> intNullable = 1;  não vai aceitar o int numero = intNullable;
     */

    public void MostraTiposNulos()
    {
        Nullable<int> intNullable = null;
        int numero = intNullable ?? 0; // Como são tipos diferentes, devemos utilizar o operador de coalescencia nula
        Console.WriteLine($"variável com valor nulo: {numero}");


        int? intNullableComValor = 1;
        int numeroQueRecebe = intNullableComValor ?? 0;
        Console.WriteLine($"Variável com valor: {numeroQueRecebe}");

        /*
         * Propriedades somente leitura: 'HasValue' e 'Value'
         * - São usadas para examinar e obter um valor de uma variável de Nullable Type
         *     - HasValue
         *          - 'true' se tiver um valor, 'false' senão tiver um valor ( no caso deve ser null para ser false)
         *     - Value
         *          - Exibe o valor atribuido
         */

        Console.WriteLine($"HasValue aplicado na variável que contém null: {intNullable.HasValue}");
        Console.WriteLine($"HasValue aplicado na variável que contém valor: {intNullableComValor.HasValue}");

        /*Console.WriteLine($"Value aplicado na variável nula: {intNullable.Value}");
        Console.WriteLine($"Value aplicado na variável NÃO nula: {intNullableComValor.Value}");*/
    }
}