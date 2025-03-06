using Heranca_modifAcesso;
using Heranca_modifAcesso.BaseHeranca;

internal class Program
{
    public static void Main(string[] args)
    {
        ClasseDerivada cs = new ClasseDerivada();

        cs.Acessar();

        Aluno aluno = new Aluno(nome: "Marcos", matricula: 123);
        aluno.Apresentar();
    }
}