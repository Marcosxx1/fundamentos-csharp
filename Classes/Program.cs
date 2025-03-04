using System.Text;
using Classes.Entidades;

public class Program
{
    public static void Main(string[] args)
    {
        /*//var pessoa = new Pessoa();
        Pessoa pessoa = new();
        //Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Marcos";
        pessoa.Sobrenome = "Sobrenome";
        pessoa.Idade = new DateTime(1900, 10, 10);

        pessoa.Saudacao();

        // Argumentos
        String resultado = pessoa.CalculaSoma(1, 2);
        Console.WriteLine(resultado);

        Aluno aluno = new Aluno();
        aluno.Nome = "Marcos";
        aluno.Idade = 18;
        aluno.Sexo = "alguma coisa";
        aluno.Aprovado = "S";

        Curso curso = new Curso();
        // passamos a referencia do objeto
        curso.Resultado(aluno);

        Aluno aluno = new Aluno("Marcos", 19, "QW","S");
        Console.WriteLine(aluno.Aprovado == null ? "é nulo" : aluno.Aprovado);
        Console.WriteLine(aluno.Nome == null ? "é nulo" : aluno.Nome);
        Console.WriteLine(aluno.Sexo == null ? "é nulo" : aluno.Sexo);
        Console.WriteLine(aluno.Idade == 0 ? "é nulo" : aluno.Idade);*/

        Carro carro = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
        // ford
        Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

        Console.WriteLine(carro);
        carro.VelocidadeMaxima(carro.Potencia);
        carro.Acelerar(carro.Marca);
        Console.WriteLine(ford);
        carro.VelocidadeMaxima(carro.Potencia);
        carro.Acelerar(carro.Marca);
        
        
        // Métodos estáticos
        MetodosEstaticos.DizOla();
        MetodosEstaticos.DizOla("Marcos");
        var result = MetodosEstaticos.SomaDoisNumeros(1, 2);
        Console.WriteLine(result);

        Produto produto = new Produto();
        produto.Nome = "Produto 1";
        produto.Preco = 10;
        produto.Desconto = 0.05;
        produto.PrecoFinal = produto.Preco - produto.Desconto;
    }
}