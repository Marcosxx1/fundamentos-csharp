using System.Runtime.Intrinsics.Arm;

namespace IEnumerableExample.entidades;

public class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }

    public Aluno()
    {
    }

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public static List<Aluno> InstanciaListaAlunos()
    {
        List<Aluno> listaAlunos = new List<Aluno>
        {
            new Aluno("Maria", 8.75),
            new Aluno("Manoel", 6.95),
            new Aluno("Amanda", 7.25),
            new Aluno("Carlos", 6.55),
            new Aluno("Jaime", 8.50),
            new Aluno("Debora", 5.95),
            new Aluno("Alicia", 9.25),
            new Aluno("Sandra", 5.55),
            new Aluno("Marta", 7.85),
            new Aluno("Sueili", 9.15)
        };

        return listaAlunos;
    }

    public static void ExibeListaDeAlunos(List<Aluno> alunos)
    {
        Console.WriteLine("Lista de alunos: ");
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Aluno: {aluno.Nome}, nota: {aluno.Nota}");
        }
    }

    public static void MostraMediaEContagemDeAlunos(List<Aluno> alunos)
    {
        double mediaNotas = alunos.Average(aluno => aluno.Nota);
        int totalAlunos = alunos.Count;

        Console.WriteLine($"\nMédia aritmética das notas dos alunos: {mediaNotas}");
        Console.WriteLine($"\nTotal de alunos: {totalAlunos}");
    }

    public static void AdicionaAlunoALista(List<Aluno> lista, Aluno aluno)
    {
        lista.Add(aluno);
    }

    public static void EncontraEApagaAluno(List<Aluno> alunos, string nome)
    {
        try
        {
            var aluno = alunos.Find(valor => valor.Nome == nome);
            alunos.Remove(aluno);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Aluno não encontrado");
        }
    }

    public static void ExibeListaOrdenada(List<Aluno> alunos)
    {
        Console.WriteLine("\nLista Ordenada: ");

        alunos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Aluno: {aluno.Nome}, nota: {aluno.Nota}");
        }
    }

    public static void ExibeListaDeAlunosComNotaMaiorOuIgualAOito(List<Aluno> alunos)
    {
        Console.WriteLine("\nExibeListaDeAlunosComNotaMaiorOuIgualAOito");
        var alunosComNotaAlta = alunos.FindAll(aluno => aluno.Nota >= 8);
        foreach (var aluno in alunosComNotaAlta)
        {
            Console.WriteLine($"Aluno: {aluno.Nome}, nota: {aluno.Nota}");
        }
    }
}