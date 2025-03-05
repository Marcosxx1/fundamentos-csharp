namespace ListCollection.listExample
{
    public class ListExampleCode
    {
        private List<string> _nomesVariados = new List<string>(5); // Campo

        public List<string> NomesVariados // Propriedade
        {
            get { return _nomesVariados; }
            set { _nomesVariados = value ?? new List<string>(5); }
        }

        public void AdicionaUmElementoComAdd(string valor)
        {
            NomesVariados.Add(valor);
        }

        public void AdicionarVariosElementos(List<string> valores)
        {
            NomesVariados.AddRange(valores);
        }

        public List<string> IniciaListaDeNomesVariados()
        {
            return NomesVariados = new List<string>()
            {
                "Marcos", "Aline", "Bob"
            };
        }

        public void ImprimeLista()
        {
            foreach (var nome in NomesVariados)
            {
                Console.WriteLine(nome);
            }
        }

        public void ImprimeListaVariados()
        {
            foreach (var nome in NomesVariados)
            {
                Console.WriteLine(nome);
            }
        }

        public void AdicionaUmElementoComInsert(int index, string valor)
        {
            if (index >= 0 && index <= NomesVariados.Count) // Verifica se o índice é válido
            {
                NomesVariados.Insert(index, valor);
            }
            else
            {
                Console.WriteLine($"Índice {index} fora do intervalo da lista. Não é possível inserir.");
            }
        }

        public void AdicionarVariosElementosInsertRange(int i, List<string> valores)
        {
            NomesVariados.InsertRange(i, valores);
        }

        public string EncontraPorOcorrenciaDeLetra(string s)
        {
            return NomesVariados.Find(nome => nome.Contains(s)); //Returns:
            //  The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type T.
        }

        public List<string> EncontraTodasOcorrencias(string valor)
        {
            return NomesVariados.FindAll(nome => nome.Contains(valor));
        }

        public void RemoveElemento(string valor)
        {
            NomesVariados.Remove(valor);
        }

        public void RemoveElementoPorIndice(int index)
        {
            NomesVariados.RemoveAt(index);
        }

        public void Exemplo()
        {
            List<int> numeros = new List<int> { 1, 6, 3, 9, 2, 5 };

            // LINQ Query
            var resultado = from n in numeros
                where n > 5
                orderby n
                select n;

            var resultado2 = numeros
                .Where(numero => numero > 5)
                .OrderBy(numero => numero);
        }
    }
}