using POO_simplificado.entidades;

namespace POO_simplificado;

class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();
        func.Nome = "Marcos";
        func.Email = "marcos@email.com";
        func.Empresa = "Alguma empresa";
        func.Salario = 10;
        
        func.Identificar();

        Aluno aluno = new Aluno();
        aluno.Nome = "Marcos";
        aluno.Email = "XXXXXXXXXXXXXXXX";
        aluno.Curso = "Algum curso";
        aluno.Nota = 123456;
        
        aluno.Identificar();
    }
}