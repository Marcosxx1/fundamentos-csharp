using Enum.enums;

namespace Enum;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"Primeiro valor do enum DiasDaSemana {DiasDaSemana.SEGUNDA} e seu número é {(int) DiasDaSemana.SEGUNDA}");
 
        Console.WriteLine($"Cor, indice 0 : {(int) Cores.BRANCO}, nome {Cores.BRANCO}");
        Console.WriteLine($"Cor, indice 1 : {(int) Cores.VERMELHO}, nome {Cores.VERMELHO}");
        Console.WriteLine($"Cor, indice 2 : {(int) Cores.PRETO}, nome {Cores.PRETO}");
        Console.WriteLine($"Cor, indice 3 : {(int) Cores.CINZA}, nome {Cores.CINZA}");
        Console.WriteLine($"Cor, indice 4 : {(int) Cores.PRATA}, nome {Cores.PRATA}");
        Console.WriteLine($"Cor, indice 5 : {(int) Cores.AZUL}, nome {Cores.AZUL}");

        int entradaUsuario = Convert.ToInt32(1);
        
        Cores  nomeMembroEnum = (Cores)entradaUsuario;

        Console.WriteLine($"Valor dado pelo usuário: { nomeMembroEnum}");

        /*pOR PADRÃO OS VALORES ASSOCIADOS AO MEMBROS DE UM ENUM SÃO DO TIPO INT
         O primeiro membro de um enum tem o valor - 0 de cada membro seguinte é
         incrementado de 1. (Quando nenhum valor for atribuido)

         É um tipo de valor, sendo alocado na memória stack

         Podemos atribuir valores diferentes aos membros de um enum, uma alteração
         no valor padrão de um membro enum,atribuirá para todos  osoutros membros
         sequencialmente
         */
    }
}