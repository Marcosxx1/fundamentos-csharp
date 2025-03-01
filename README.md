- [Explicando `ref`](#explicando-ref)
- [Diferença entre `ref` e `out`](#diferença-entre-ref-e-out)
- [Parâmetros Nomeados](#parâmetros-nomeados)


dotnet --list-sdks lsitar os sdks

Podemos escolher a versão do sdk criando um arquivo **global.json** na raiz da pasta

```json
{
  "sdk": {
    "version": "6.x.x"
  }
}
```

Caso nenhum arquivo global.json for encontrado, ou o arquivo globaljson não especificar uma versãodo SDK, a versão 
**mais recente do SDK instalada será utilizada**

 
### **Explicando`ref`**
No C#, a palavra-chave `ref` permite que um **parâmetro seja passado por referência**, ou seja, em vez
de passar apenas uma cópia do valor da variável, passamos um **referência para a variável original**.
Isso significa que qualquer alteração feita no parâmetro dentro do método **afeta diretamente a variável
original**.

```csharp
public class Calculo
{
    public void Dobrar(ref int y)
    {
         y *= 2;
         Console.WriteLine($"O valor dobrado é {y}");
    }
}

class Program
{
    static void Main()
    {
        Calculo calculo = new Calculo();
        int valor = 10;

        Console.WriteLine($"O valor original é {valor}");
        
        calculo.Dobrar(ref valor);
        
        Console.WriteLine($"O valor depois da chamada é {valor}");
    }
}
```

### **Saída esperada:**
```plaintext
O valor original é 10
O valor dobrado é 20
O valor depois da chamada é 20
```
Noteemos que `valor` foi **modificado diretamente**, porque foi passado por referência.

---

### **É igual a ponteiros?**
Não exatamente. Aqui estão algumas diferenças:

| **Característica** | `ref` em C# | Ponteiros em C |
|-------------------|------------|---------------|
| **Tipo de dado** | Trabalha com tipos por valor e referência | Trabalha diretamente com endereços de memória |
| **Sintaxe** | Usa `ref` antes do argumento no método e na chamada | Usa `*` para declarar e `&` para obter o endereço |
| **Segurança** | Mais seguro, gerenciado pelo .NET | Risco de manipular memória diretamente |
| **Necessidade de inicialização** | O argumento passado com `ref` deve estar inicializado | Pode apontar para `NULL` |
| **Controle de memória** | O .NET gerencia automaticamente | O programador precisa liberar memória manualmente |



## **Diferença entre `ref` e `out`**
| Característica  | `ref`  | `out`  |
|----------------|--------|--------|
| **Passagem por referência?** | ✅ Sim | ✅ Sim |
| **A variável precisa ser inicializada antes da chamada?** | ✅ Sim | ❌ Não |
| **O método precisa obrigatoriamente atribuir um valor ao parâmetro?** | ❌ Não | ✅ Sim |
| **Uso típico** | Modificar valores dentro do método e manter o original atualizado | Retornar múltiplos valores de um método |

---
 
```csharp
public class Calculo
{
    public double CalcularAreaPerimetro(double raio, out double area)
    {
        // O out obriga que 'area' seja inicializada aqui dentro
        area = Math.PI * Math.Pow(raio, 2); 

        // Calculando o perímetro
        double perimetro = 2 * Math.PI * raio;

        return perimetro; // Retorna o perímetro
    }
}

class Program
{
    static void Main()
    {
        Calculo calculo = new Calculo();
        
        // Chamando o método e pegando os valores de retorno
        double circunferencia = calculo.CalcularAreaPerimetro(10, out double area);

        Console.WriteLine($"Perímetro da circunferência: {circunferencia}");
        Console.WriteLine($"A área é {area}");
    }
}
```

### **Saída esperada**
```plaintext
Perímetro da circunferência: 62.83185307179586
A área é 314.1592653589793
```

---

 
## **Quando usar `out`?**
- Quando queremos **retornar múltiplos valores de um método** sem precisar criar uma classe ou `Tuple`.
- Quando **o valor passado não precisa estar inicializado** antes da chamada (diferente do `ref`).

✅ **Exemplo comum de uso:**
```csharp
bool sucesso = int.TryParse("123", out int numero);
if (sucesso)
{
    Console.WriteLine($"Número convertido: {numero}");
}
```
Aqui, `out` permite que `TryParse` **retorne um valor extra (o número convertido), além do booleano indicando sucesso ou falha.**

--- 

## Parâmetros Nomeados
Os **parâmetros nomeados** nos permitem que passemos argumentos especificando o nome do parâmetro, **independentemente da ordem**.

```csharp
public void ExibirMensagem(string nome, int idade)
{
    Console.WriteLine($"Nome: {nome}, Idade: {idade}");
}

// Chamando o método com parâmetros nomeados
ExibirMensagem(idade: 25, nome: "Carlos");
```

**Vantagens:**
- **Melhora a legibilidade** do código.
- **Evita confusão** ao passar muitos parâmetros.
- **Útil em métodos com muitos argumentos opcionais**.
