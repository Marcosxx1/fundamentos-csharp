namespace fundamentos
{
    public class TiposPreDefinidos
    {
        public void TiposPreDefinidosMain()
        {
            /* Tipos numéricos de ponto flutuante
             float
             double
             decimal
             
             - Representam números reais
             - São tipos de valor armazenados na stack
             - O valor padrão dos tipos de dados de ponto fltuante é zero (0)
             - Dão suporte a operadores aritméticos de comparação (<.<, >=,<=,!=) e de igualdade (==)
             - O tipo 'double' é usado para cálculos científicos e o decimal para cálculos financeiros
             - São tipos que podemos inicializar usando literais (f-F, d-D, m-M)
             */
            Console.WriteLine("Tipos de dados pré-definidos");
            float valorFloat = 1.0123123123123f;
            double valorDouble = 1.0123123123123d;
            decimal valorDecimal = 1.0123123123123m;

            Console.WriteLine($"Valor float: {valorFloat}");
            Console.WriteLine($"Valor double: {valorDouble}");
            Console.WriteLine($"Valor decimal: {valorDecimal}");
            Console.WriteLine();

        }
    }
}