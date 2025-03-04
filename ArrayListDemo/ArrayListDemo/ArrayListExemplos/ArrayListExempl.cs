using System.Collections;

namespace ArrayListDemo.ArrayListExemplos;

public class ArrayListExempl
{
    // Cria propriedade:
    private ArrayList primeiroArrayList = new();
    private ArrayList segundoArrayList = new ArrayList();


    public void DefineCapacity()
    { 
        primeiroArrayList.Capacity = 4; // Alocamos espaço inicial para otimizar o desempenho
     }

    public void AdicionaUmElemento(int valor)
    {
        primeiroArrayList.Add(valor);
        segundoArrayList.Add(valor);
    }

    public void AdicionaVariosElementos(ArrayList valor)
    {
        primeiroArrayList.AddRange(valor);
        segundoArrayList.AddRange(valor);
    }

    public void AdicionaAPartirDeUmIndice(int index, ArrayList valor)
    {
        primeiroArrayList.InsertRange(index, valor);
    }

    public void MostraPrimeirp()
    {
        Console.WriteLine("Mostra primeiro");
        foreach (var primeiro   in primeiroArrayList)
        {
            Console.WriteLine($"{primeiro}");   
        }
    }
    
    public void MostraSegundo()
    {
        Console.WriteLine("Mostra Segundo");
        foreach (var segundo   in segundoArrayList)
        {
            Console.WriteLine($"{segundo}");   
        }
    }

    public void RemoveUmValor(object o)
    {
        primeiroArrayList.Remove(o);
        segundoArrayList.Remove(o);
        
    }

    public void RemoveIndiceEspecifico(int index)
    {
        primeiroArrayList.RemoveAt(index);
        segundoArrayList.RemoveAt(index);
        
    }


    public void removePorRange(int i, int i1)
    {
        primeiroArrayList.RemoveRange(i, i1);
        segundoArrayList.RemoveRange(i, i1);
    }
}