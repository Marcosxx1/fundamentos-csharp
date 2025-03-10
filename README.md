﻿- [Explicando `ref`](#explicando-ref)
- [Diferença entre `ref` e `out`](#diferença-entre-ref-e-out)
- [Parâmetros Nomeados](#parâmetros-nomeados)
- [Métodos e Propriedades Estáticas](#métodos-e-propriedades-estáticas)
- [List e ArrayList](#list-e-arraylist)
- [`List<T>` e principais métodos de consultas LINQ](#listt-e-principais-métodos-deconsultas-linq)
- [Entendendo Delegates Multicast e Fila de Mensagens](#entendendo-delegates-multicast-e-fila-de-mensagens)
- [Eventos em C# e o Uso de EventArgs](#eventos-em-c-e-o-uso-de-eventargs)


- dotnet --list-sdks lsitar os sdks

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

| **Característica**               | `ref` em C#                                           | Ponteiros em C                                    |
|----------------------------------|-------------------------------------------------------|---------------------------------------------------|
| **Tipo de dado**                 | Trabalha com tipos por valor e referência             | Trabalha diretamente com endereços de memória     |
| **Sintaxe**                      | Usa `ref` antes do argumento no método e na chamada   | Usa `*` para declarar e `&` para obter o endereço |
| **Segurança**                    | Mais seguro, gerenciado pelo .NET                     | Risco de manipular memória diretamente            |
| **Necessidade de inicialização** | O argumento passado com `ref` deve estar inicializado | Pode apontar para `NULL`                          |
| **Controle de memória**          | O .NET gerencia automaticamente                       | O programador precisa liberar memória manualmente |

## **Diferença entre `ref` e `out`**

| Característica                                                        | `ref`                                                             | `out`                                   |
|-----------------------------------------------------------------------|-------------------------------------------------------------------|-----------------------------------------|
| **Passagem por referência?**                                          | ✅ Sim                                                             | ✅ Sim                                   |
| **A variável precisa ser inicializada antes da chamada?**             | ✅ Sim                                                             | ❌ Não                                   |
| **O método precisa obrigatoriamente atribuir um valor ao parâmetro?** | ❌ Não                                                             | ✅ Sim                                   |
| **Uso típico**                                                        | Modificar valores dentro do método e manter o original atualizado | Retornar múltiplos valores de um método |

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

Aqui, `out` permite que `TryParse` **retorne um valor extra (o número convertido), além do booleano indicando sucesso ou
falha.**

--- 

## Parâmetros Nomeados

Os **parâmetros nomeados** nos permitem que passemos argumentos especificando o nome do parâmetro, **independentemente
da ordem**.

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

## Métodos e Propriedades Estáticas

Os **métodos estáticos** pertencem à classe, e não a uma instância específica de um objeto.  
Para utilizá-los, basta chamá-los diretamente pelo nome da classe:

```csharp
Classe.MetodoEstatico();
```

Se um objeto for instanciado, **ele não terá acesso ao método estático**.

Os **atributos estáticos** também pertencem à classe e não aos objetos individuais.  
Isso significa que **o valor do atributo estático é compartilhado entre todas as instâncias da classe**.

```csharp
public class Exemplo
{
    public static int Contador = 0;

    public Exemplo()
    {
        Contador++;
    }
}

Exemplo obj1 = new Exemplo();
Exemplo obj2 = new Exemplo();

Console.WriteLine(Exemplo.Contador); // Saída: 2
```

## Getters, Setters, Campos e Propriedades

```csharp
public class Usuario
{
    private string nome;  // 🔒 Campo privado

    public string Nome
    {
        get { return nome; }  // 📤 Getter (pega o valor do campo privado)
        set { nome = value; } // 📥 Setter (altera o campo privado)
    }
}
```

Quando fazemos

```csharp
u.Nome = "Carlos";  
```

É **equivalente** a chamar `u.setNome("Carlos")` no Java!  
O **setter da propriedade pública (`Nome`) está atribuindo o valor ao campo privado (`nome`)**.

E quando faz:

```csharp
Console.WriteLine(u.Nome);
```

Está **chamando o getter da propriedade `Nome`**, que retorna o valor armazenado no campo privado `nome`.

### **🔹 Resumo**

✅ **O campo `nome` fica encapsulado** dentro da classe.  
✅ **A propriedade `Nome` controla o acesso ao campo `nome`**, de forma parecida com os métodos `getNome()` e `setNome()`
no Java.

Se quiser, pode até adicionar validação no setter:

```csharp
public string Nome
{
    get { return nome; }
    set 
    { 
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("O nome não pode ser vazio!");
        nome = value; 
    }
}
``` 

### Auto-property:

Quando usamos **auto-properties** em C#, como neste exemplo:

```csharp
public class Usuario
{
    public string Nome { get; set; } // Auto-property
}
```

A grande diferença é que **não precisamos definir um campo privado manualmente**, pois o **C# cria automaticamente um
campo oculto para armazenar o valor**.

---

## **🔹 Mas onde está o campo privado?**

No caso de **auto-properties**, o compilador C# faz isso internamente. Ou seja, este código:

```csharp
public class Usuario
{
    public string Nome { get; set; } // Auto-property
}
```

É equivalente a escrever **manualmente** assim:

```csharp
public class Usuario
{
    private string nome; // 🔒 Campo privado

    public string Nome
    {
        get { return nome; }  // 📤 Getter
        set { nome = value; } // 📥 Setter
    }
}
```

A única diferença é que no **auto-property** (`public string Nome { get; set; }`), o **campo privado é gerado
automaticamente pelo compilador e não pode ser acessado diretamente**.

---

## **🔹 O que muda no uso externo?**

Nada! Ambas as abordagens funcionam do mesmo jeito:

```csharp
Usuario u = new Usuario();
u.Nome = "Carlos";  // Isso usa o setter interno gerado pelo compilador
Console.WriteLine(u.Nome); // Isso usa o getter interno gerado pelo compilador
```

O **auto-property apenas evita código boilerplate**, tornando o código mais limpo.

---

## **🔹 Quando usar auto-properties?**

✅ **Quando não precisa de validação ou lógica extra** no `get` e `set`.  
✅ **Quando quer um código mais enxuto** e mais fácil de manter.

### **Exemplo sem auto-property (com validação):**

```csharp
public class Usuario
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nome inválido!");
            nome = value;
        }
    }
}
```

### **Exemplo com auto-property (sem validação):**

```csharp
public class Usuario
{
    public string Nome { get; set; } // Sem validação, código mais curto
}
```

---

## **🚀 Resumo Final**

| **Abordagem**                        | **Tem campo privado?**                              | **Tem getter/setter customizado?**       | **Melhor uso**                                      |
|--------------------------------------|-----------------------------------------------------|------------------------------------------|-----------------------------------------------------|
| **Manual (`private + propriedade`)** | ✅ Sim, declarado explicitamente                     | ✅ Sim, podemos modificar o getter/setter | Quando precisa de lógica extra (ex.: validação)     |
| **Auto-property (`{ get; set; }`)**  | ✅ Sim, mas é gerado automaticamente pelo compilador | ❌ Não, é sempre um simples `get` e `set` | Quando quer um código mais limpo e sem lógica extra |

## Structs no C#

Structs no C# são estruturas de dados do tipo **valor**, ao invés de **referência** (como uma classe).

### Diferença entre Struct e Classe

- Quando criamos uma **classe**, ela é armazenada na **heap** e a referência fica salva na **stack**.
- Quando usamos **structs**, a referência sempre estará na **stack**.

### Quando Usar Structs

Deve-se definir um `struct` em vez de uma `class` se:

- As instâncias do tipo forem **pequenas** e normalmente de **curta duração**.
- Se forem **comumente incorporadas** em outros objetos.

### Quando **Não** Usar Structs

Evite usar `structs` se **qualquer** das seguintes condições for verdadeira:

1. Representa logicamente um **único valor**, semelhante aos tipos primitivos (`int`, `double`, etc.).
2. Tem um tamanho de instância **inferior a 16 bytes**.
3. É **imutável**.
4. Precisa sofrer **conversão para tipo de referência** (boxing) com frequência.

### Exemplo de Struct

```csharp
struct Ponto
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public Ponto(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        Ponto p1 = new Ponto(10, 20);
        Console.WriteLine($"Ponto: ({p1.X}, {p1.Y})");
    }
}
```

### Exemplo de Struct Imutável

```csharp
struct PontoImutavel
{
    public int X { get; }
    public int Y { get; }
    
    public PontoImutavel(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        PontoImutavel p1 = new PontoImutavel(10, 20);
        Console.WriteLine($"Ponto: ({p1.X}, {p1.Y})");
    }
}
```

## List e ArrayList

O comportamento de **ArrayList**

- Uma coleção ArrayList pode armazenar elementos de diversos tipos de dados: **Value types** E **Reference Types**
- Qualquer tipo de referência ou valor que é adicionado a um **ArrayList** é implicitamente convertido para *
  *System.Object**
- Se ositems são _tipos devalor_, eles devem sofrer um **boxing** quando adicionado à coleção, e **unboxing**
  quandoelessão recuperados
- A _coersão_, (boxing e unboxing) são operações que degradam o desempenho, que pode ser significativo quando devemos
  percorrer grandes coleções

O comportamento de **List< T >**
Comparado com o ArrayList(), podemos criar uma lista de itens usando a coleção de um tipo específico ao invés de usar o
ArrayList()
que além de ser mais seguro é também mais rápido, especialmente quando os items da lista são tipos de valor, ex:

```c#
//Arraylist
ArrayList lista = new ArrayList();
lista.Add(1);           // boxing
lista.add(3);           // boxing


// para recuperar o valor
var elemento = lista[0]; // unboxing
var item = (int)lista[1] // unboxing
```

```csharp
//List<T> sem boxing e unboxing
List<int> lista = new List<int>();
lista.Add(1);
lista.Add(3);

var elemento = lista[0];
int item = lista[1];
```

## `List<T>` e principais métodos deconsultas LINQ

- `Any()`: Determina se qualquer elemento de uma sequência existe ou atende a uma condição. (Determina se a coleção
  contém elementos)
- `FirstOrDefault()`: Retorna o primeiro elemento da coleção que satisfaz uma condição opcional. Retorna o valor padrão
  do tipo caso não encontre nenhum elemento
- `OrderBy()`: Classifica os elementos na coleção em ordem crescente com base em uma determinada condição e retorna a
  coleção classificada
- `ToList`: Recebe um tipo IEnumerable e oconverte em um tipo `List`
- `Where()`: Retorna todos os elementos da coleção que satisfazem uma determinada condição. (Execução adiada)

### `List<T>` x `IEnumerable<T>`

- **`IEnumerable<T>`** descreve um comportamento de iteração sobre uma coleção, enquanto **`List<T>`** implementa esse comportamento. Por exemplo:
  - `public class List<T> : IList<T>, IList, IReadOnlyList<T>`
  - `public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable`

---

#### Características do `IEnumerable<T>`:

- **Somente leitura (Read-only)**: Não é possível alterar a coleção, apenas ler.
- **Iteração**:
  - Possui um método para retornar o próximo item da coleção.
  - Não precisa carregar toda a coleção na memória de uma vez.
  - Não sabe quantos elementos a coleção possui.
  - Ao ser iterada em um laço `foreach`, ela vai retornando o próximo item até o fim da coleção.
- **Execução adiada (Lazy Execution)**:
  - O compilador adia a execução até que seja necessário, ou seja, somente é executada quando iterada, como em um laço `foreach`/`for` ou quando um valor é extraído.

---

#### Características da `List<T>`:

- **Memória completa**: A `List<T>` possui toda a coleção na memória e sabe exatamente quantos itens ela contém.
- **Acesso e alteração**:
  - Implementa uma variedade de métodos que permitem acessar e alterar a coleção.


## Entendendo Delegates Multicast e Fila de Mensagens

### Introdução

Ao trabalhar com sistemas distribuídos ou mesmo dentro de uma aplicação, frequentemente nos deparamos com cenários onde uma única ação deve desencadear várias outras. Um exemplo comum disso é quando lidamos com **Message Queues (MQs)**, onde um evento publicado pode ser consumido por diferentes consumidores.

Neste trecho, explicarei o conceito de **delegates multicast** em C# e sua relação com filas de mensagens, usando um exemplo prático de CRUD.

---

### O que são Delegates Multicast?

Um **delegate multicast** é um tipo especial de delegate em C# que pode armazenar uma lista de métodos e chamá-los em sequência. É como se tivéssemos uma fila de consumidores que executam uma tarefa assim que recebem um evento.

#### Como funciona?

1. Criamos um delegate.
2. Associamos vários métodos a ele.
3. Quando invocamos o delegate, todos os métodos associados são executados na ordem em que foram adicionados.
4. Podemos remover métodos do delegate a qualquer momento.

Exemplo:

```csharp
public delegate void DelegateMulticast(string mensagem);

public class Metodos
{
    public static void Metodo1(string mensagem) => Console.WriteLine($"Método 1: {mensagem}");
    public static void Metodo2(string mensagem) => Console.WriteLine($"Método 2: {mensagem}");
    public static void Metodo3(string mensagem) => Console.WriteLine($"Método 3: {mensagem}");
}

internal class Program
{
    public static void Main()
    {
        DelegateMulticast delMult = Metodos.Metodo1;
        delMult += Metodos.Metodo2;
        delMult += Metodos.Metodo3;
        
        delMult("Olá");
        
        delMult -= Metodos.Metodo2;
        delMult("Olá novamente");
    }
}
```

---

## Aplicando ao CRUD

Agora, vamos aplicar esse conceito a um CRUD de usuário. Quando cadastramos um usuário, podemos querer realizar várias operações, como:

1. Salvar no banco de dados.
2. Enviar um e-mail de boas-vindas.
3. Criar um log de auditoria.

Usamos um **delegate multicast** para executar todas essas operações automaticamente:

```csharp
public class UsuarioServico
{
    public static void SalvarNoBanco(string nome)
    {
        Console.WriteLine($"Usuário {nome} salvo no banco de dados.");
    }

    public static void EnviarEmailBoasVindas(string nome)
    {
        Console.WriteLine($"E-mail de boas-vindas enviado para {nome}.");
    }

    public static void CriarLog(string nome)
    {
        Console.WriteLine($"Log: Usuário {nome} foi cadastrado.");
    }
}

public delegate void OperacaoCadastro(string nome);

class Program
{
    static void Main()
    {
        OperacaoCadastro operacoes = UsuarioServico.SalvarNoBanco;
        operacoes += UsuarioServico.EnviarEmailBoasVindas;
        operacoes += UsuarioServico.CriarLog;

        operacoes("João");

        Console.WriteLine("\nRemovendo envio de e-mail...\n");

        operacoes -= UsuarioServico.EnviarEmailBoasVindas;
        operacoes("Maria");
    }
}
```

Aqui, assim que cadastramos um usuário, todas as operações vinculadas ao delegate são executadas automaticamente.

---

### Comparando com Message Queues (MQ)

Quando trabalhamos com sistemas distribuídos, usamos filas de mensagens para propagar eventos. Por exemplo:

1. Um serviço publica uma mensagem "Usuário cadastrado" em uma fila.
2. Vários consumidores pegam essa mensagem e realizam suas tarefas (salvar no banco, enviar e-mail, criar log).
3. Se um consumidor for removido da fila, ele deixa de processar mensagens futuras.

Isso é muito similar aos **delegates multicast**, onde adicionamos e removemos métodos dinamicamente.

---
## Métodos Anônimos e Expressões Lambda

Além dos delegates multicast, podemos utilizar **métodos anônimos** e **expressões lambda** para simplificar nosso código.

### **Método Anônimo**

Um método anônimo permite definir uma função sem precisar nomeá-la explicitamente. Veja um exemplo em que usamos `Find` para buscar um nome em uma lista:

```csharp
List<string> nomes = new List<string> { "Alice", "Bob", "Carlos" };

var resultado = nomes.Find(delegate(string nome)
{
    return nome.Equals("Bob");
});

Console.WriteLine(resultado);
```

### **Expressões Lambda**

Uma expressão lambda é uma forma ainda mais concisa de escrever funções anônimas. O exemplo acima pode ser reescrito usando uma lambda:

```csharp
var resultadoLambda = nomes.Find(nome => nome.Equals("Bob"));
Console.WriteLine(resultadoLambda);
```

Lambdas são úteis para simplificar código e torná-lo mais legível, especialmente ao trabalhar com delegates e LINQ.

---


## Delegates em C#: Predicate, Action e Func

Em C#, **delegates** são referências a métodos que podem ser armazenadas em variáveis. Entre os tipos mais comuns, temos os **Predicate**, **Action** e **Func**, que oferecem formas simplificadas de trabalhar com delegação de métodos, tornando o código mais limpo e reutilizável.

---

### Delegate Predicate

O **Predicate** é um delegate que sempre retorna um booleano (`true` ou `false`). Ele é geralmente usado para verificar se um elemento atende a uma condição específica.

#### Exemplo:
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static bool MaiorQueCinco(int numero)
    {
        return numero > 5;
    }

    static void Main()
    {
        Predicate<int> verificaNumero = MaiorQueCinco;
        Console.WriteLine(verificaNumero(7)); // True
        Console.WriteLine(verificaNumero(3)); // False
    }
}
```

#### Aplicação prática:
Um uso comum do `Predicate` é em métodos como `List<T>.Find`, que busca um item em uma lista com base em um critério.

```csharp
List<int> numeros = new List<int> { 1, 3, 5, 7, 9 };
int resultado = numeros.Find(x => x > 5);
Console.WriteLine(resultado); // 7
```

---

### Delegate Action

O **Action** é um delegate que não retorna valor (`void`). Ele é útil para definir métodos que executam uma ação sem precisar de um retorno.

### Exemplo:
```csharp
using System;

class Program
{
    static void ExibirMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    static void Main()
    {
        Action<string> meuDelegate = ExibirMensagem;
        meuDelegate("Olá, Action!"); // Saída: Olá, Action!
    }
}
```

#### Aplicação prática:
Um `Action` pode ser usado para iterar sobre listas e executar operações em cada elemento.

```csharp
List<string> nomes = new List<string> { "Ana", "Carlos", "Beatriz" };
nomes.ForEach(nome => Console.WriteLine(nome));
```

---

### Delegate Func

O **Func** é um delegate que sempre retorna um valor. Ele pode receber até 16 parâmetros e deve definir o tipo de retorno no final da sua assinatura.

### Exemplo:
```csharp
using System;

class Program
{
    static int Soma(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Func<int, int, int> somaDelegate = Soma;
        Console.WriteLine(somaDelegate(3, 4)); // 7
    }
}
```

### Aplicação prática:
Podemos usar `Func` para aplicar transformações a elementos de uma lista, como dobrar os valores de uma sequência de números.

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4 };
List<int> dobrados = numeros.ConvertAll(x => x * 2);
Console.WriteLine(string.Join(", ", dobrados)); // 2, 4, 6, 8
```

---
# Eventos em C# e o Uso de EventArgs

## Introdução

Eventos são um mecanismo poderoso em C# para permitir a comunicação entre diferentes partes de um programa sem criar um forte acoplamento entre elas. Um exemplo comum no dia a dia é quando um pedido é criado em um sistema de compras, disparando várias notificações, como e-mails e SMS.

Neste documento, exploramos como funcionam os eventos em C#, com um foco especial no uso de **EventArgs**.

---

## Implementando Eventos com EventArgs

Os eventos normalmente são acompanhados por **EventArgs**, que são usados para transportar informações sobre o evento para os assinantes. Isso permite um sistema mais flexível e escalável.

### Exemplo prático: Pedido com Notificações

Aqui temos um sistema onde, quando um pedido é criado, ele notifica diferentes serviços (e-mail e SMS):

```csharp
using System;

namespace Eventos.Classes
{
    public class PedidoEventArgs : EventArgs
    {
        public string NumeroPedido { get; }
        public string Email { get; }
        public string Telefone { get; }

        public PedidoEventArgs(string numeroPedido, string email, string telefone)
        {
            NumeroPedido = numeroPedido;
            Email = email;
            Telefone = telefone;
        }
    }

    public class Email
    {
        public static void EnviarEmail(object sender, PedidoEventArgs e)
        {
            Console.WriteLine($"\ud83d\udce7 Enviando e-mail para {e.Email} sobre o pedido {e.NumeroPedido}");
        }
    }

    public class Sms
    {
        public static void EnviarSms(object sender, PedidoEventArgs e)
        {
            Console.WriteLine($"\ud83d\udcf2 Enviando SMS para {e.Telefone} sobre o pedido {e.NumeroPedido}");
        }
    }

    public delegate void PedidoEventHandler(object sender, PedidoEventArgs e);

    public class Pedido
    {
        public event PedidoEventHandler? PedidoCriado;

        public void CriarPedido(string numeroPedido, string email, string telefone)
        {
            Console.WriteLine($"\ud83d\uded2 Pedido {numeroPedido} criado!");
            PedidoCriado?.Invoke(this, new PedidoEventArgs(numeroPedido, email, telefone));
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Pedido pedido = new Pedido();
            pedido.PedidoCriado += Email.EnviarEmail;
            pedido.PedidoCriado += Sms.EnviarSms;

            pedido.CriarPedido("12345", "cliente@email.com", "11999999999");
        }
    }
}
```

---

## Por que usar EventArgs?

O uso de `EventArgs` traz vários benefícios, como:

1. **Flexibilidade**: Permite que assinantes do evento recebam informações detalhadas, evitando depender de variáveis globais.
2. **Escalabilidade**: Novos dados podem ser adicionados sem alterar a assinatura do evento.
3. **Boas Práticas**: Segue padrões recomendados do .NET, facilitando a compreensão do código por outros desenvolvedores.

---


Eventos são uma forma eficaz de permitir comunicação entre componentes de forma desacoplada. O uso de **EventArgs** melhora a organização do código, tornando-o mais modular e extensível. Esse conceito é amplamente utilizado em aplicações reais, como notificadores de pedidos, logs de auditoria e integrações com serviços externos.

Com essa abordagem, conseguimos um código mais robusto, escalável e fácil de manter! 🚀

