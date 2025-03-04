using Structs.entidade;

namespace Structs;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente();
        cliente.Nome = "João";
        cliente.Idade = 30;

        Console.WriteLine($"O nome do cliente é {cliente.Nome} e sua idade é {cliente.Idade}");
        
        Cliente.ExibirInfo("Aline", "aline@email.com");
        Cliente.ExibirInfo("Aline", "aline@email.com", 19);
    }
    
    /*Structs no C# são estrtuturas de dados do tipo de valor ao invés de
     tipos de referencia (como uma classe)
     
     Quando criamos uma classe é salvo na heap e a referencia fica salva na stack
     Enquanto com structs, a referencia sempre estará na Stack
     
     Em questão de performance e onde usar cada uma
     
     QUANDO USAR: 
        - Definir um struct em vez de uma classe se as instâncias do tipo
     forem pequenas e normalmente de curta duração ou se forem comumente incorporadas
     em outros objetos
     
     QUANDO NÃO USAR:
        - Devemos definir structs, a menos que o tipo tenha todas as características a
        seguir:
            1 - Representa logicamente um único valor, semelhante aos tipos primitivos
            (int, double, etc.).
            2 - Tem um tamanho de instância inferior a 16 bytes
            3 - É imitável 
            4 - Não precisará soffrer conversao para tipo de referencia (boxing) com frequencia
     */
}