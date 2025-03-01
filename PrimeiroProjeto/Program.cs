using fundamentos;

namespace PrimeiroProjeto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
          var inteiros = new TiposNumericosIntegrais();
          var preDefinidos = new TiposPreDefinidos();
          var naoNumericos = new TiposNaoNumericos();
          var tiposReferencia = new TiposDeReferencia();
          var dataEHora = new TratandoDataEHora();
          var tiposNulos = new TiposNulos();
          
          // inteiros.MostraNumericosIntegrais();
          // preDefinidos.TiposPreDefinidosMain();
          // naoNumericos.MostraNaoNumericos();
          // tiposReferencia.mostraTiposDeReferencia();
          //dataEHora.MostraDataEHora();
          tiposNulos.MostraTiposNulos();

        }
    }
}