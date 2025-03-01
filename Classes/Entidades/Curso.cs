namespace Classes.Entidades;

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, sexo: {aluno.Sexo}, com idade: {aluno.Idade}");
        if (aluno.Sexo.Equals("S"))
        {
            Console.WriteLine("\n Foi aprovado");
        }
        else
        {
            Console.WriteLine("\n Foi reprovado");
        }
    }
}