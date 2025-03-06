using IEnumerableExample.entidades;

namespace IEnumerableExample;

class Program
{
    static void Main(string[] args)
    {
        List<Limite> limiteCredito = new List<Limite>();
        for (int i = 1; i < 16; i++)
        {
            limiteCredito.Add(new Limite()
            {
                Numero = i
            }); //Instancia um objeto e define suas propriedades SEM PRECISAR DE UM CONSTRUTOR EXPLICITO
            /*
             * Que equivale a:
             * Limite limite = new Limite();
             * limite.Numero = i;
             *
             */
        }

/*
   var limitesComRestricao = limiteCredito.Where(limite => limite.AnalisaLimite());

   `limitesComRestricao` é um `IEnumerable<T>`, ou seja, a consulta só será processada quando for iterada,
   como em um `foreach` ou quando `ToList()` for chamado.

   Importante: Como `IEnumerable<T>` é avaliado a cada iteração, toda vez que `limitesComRestricao` for acessado,
   a operação `Where(limite => limite.AnalisaLimite())` será executada novamente.
*/

/*
   var limitesComRestricao = limiteCredito.Where(limite => limite.AnalisaLimite()).ToList();

   Aqui usamos `.ToList()` para **materializar** os resultados, ou seja, armazenamos os valores em uma `List<T>`.
   Dessa forma, evitamos a reexecução da consulta a cada acesso, melhorando a performance caso a coleção seja
   usada várias vezes.
*/
        /*var limitesComRestricao =
            limiteCredito.Where(limite => limite.AnalisaLimite())
                .ToList(); // Com ToList() esse where será executado somente uma vez

        if (limitesComRestricao.Count() > 3)
        {
            Console.WriteLine("Limite de crédito excedido!");
        }

        if (limitesComRestricao.Count() > 3)
        {
            Console.WriteLine("Limite de crédito excedido SEGUNDA VEZ!");
        }

        Console.WriteLine("\nFim do processamento...");
        Console.ReadKey();*/


        var alunos = Aluno.InstanciaListaAlunos();
        Aluno.ExibeListaDeAlunos(alunos);
        Aluno.MostraMediaEContagemDeAlunos(alunos);

        Aluno bob = new Aluno("Bob", 10);
        Aluno.AdicionaAlunoALista(alunos, bob);
        
        Aluno.ExibeListaDeAlunos(alunos);
        
        Aluno.EncontraEApagaAluno(alunos, "Maria");
        
        Aluno.ExibeListaDeAlunos(alunos);

        Aluno.ExibeListaOrdenada(alunos);
        
        Aluno.ExibeListaDeAlunos(alunos);
    
        Aluno.ExibeListaDeAlunosComNotaMaiorOuIgualAOito(alunos);
    }
}