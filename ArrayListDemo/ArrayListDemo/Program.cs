using System.Collections;
using ArrayListDemo.ArrayListExemplos;

namespace ArrayListDemo;

class Program
{
    static void Main(string[] args)
    {
        ArrayList valor = new ArrayList() { "", 2, "c" };
        ArrayListExempl ald = new ArrayListExempl();
        var arrayList = new ArrayList(){1,2,3, ".", "b",null}; // Quando adicionamos mais que a capacity de um AL, a Capacity é dobrada
        var arrayList2 = new ArrayList(){7,8,9, "10", "11",null}; 

        ald.DefineCapacity();
        ald.AdicionaUmElemento(1);
        ald.AdicionaVariosElementos(arrayList);
        ald.AdicionaAPartirDeUmIndice(7,arrayList2);
        ald.RemoveIndiceEspecifico(2);
        ald.removePorRange(2, 2);
        ald.RemoveUmValor(null);
        ald.MostraPrimeirp();
        ald.MostraSegundo();
        
        
    }
}