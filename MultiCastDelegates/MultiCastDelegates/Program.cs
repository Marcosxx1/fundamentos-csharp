using MultiCastDelegates.entidades;
using MultiCastDelegates.service;

public delegate void DelegateMulticast(string mensagem);

public delegate void OperacoesUsuario(string nome);

// 1 - Forma é definindo o predicate 
public delegate bool DelegatePar(int numero);


internal class Program
{
    public static void Main(string[] args)
    {
        OperacoesUsuario opcoes = UsuarioService.SalvarNoBanco;
        opcoes += UsuarioService.EnviarEmail;
        opcoes += UsuarioService.CriaLog;

        opcoes("Marcos");


        DelegateMulticast delMult = Metodos.Metodo1;
        delMult += Metodos.Metodo2;
        delMult += Metodos.Metodo3;


        delMult("Olá");

        delMult -= Metodos.Metodo2;
        delMult("Olá");

        List<string> nomes = new List<string>();
        nomes.Add("Marcos");
        nomes.Add("Aline");
        nomes.Add("Bob");

        // Método anonimo
        var resultadoMetodoAnonimo = nomes.Find(delegate(string nome) { return nome.Equals("Bob"); });

        // Expressão – lambda
        var resultadoExpressaoLambda =
            nomes.Find(nome => string.Equals(nome, "Bob", StringComparison.OrdinalIgnoreCase));

        // Delegate Predicate
        // Temos três formas de usar predicados
        
        // 1.2 
        DelegatePar delegatePar = ehPar;
        // Então utilizamos
        var resultado = delegatePar(2);
        Console.WriteLine($"Ressultado: {resultado}");
        
        // 1.3 - Podemos criar expressões lambdas e combinar com o Predicate<T> nome = expressão; para booleanos

        Predicate<int> delegateBooleano = x => x % 2 == 0;
        if (delegateBooleano(2))
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }
    }

    // 1.2 - Utilizamos o método no delegate
    public static bool ehPar(int numero)
    {
        if (numero % 2 != 0)
        {
            return false;
        }

        return true;
    }

    public static void ImprimeNome(string nome)
    {
        Console.WriteLine($"nome: {nome}");
    }
}