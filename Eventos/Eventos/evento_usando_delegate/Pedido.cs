namespace Eventos.classes;

public delegate void PedidoEventHandler(object sender, PedidoEventArgs e);

public class Pedido
{
    public event PedidoEventHandler? PedidoCriado;

    public void CriarPedido(string numeroPedido, string email, string telefone)
    {
        Console.WriteLine($"🛒 Pedido {numeroPedido} criado!");

        PedidoCriado?.Invoke(this, new PedidoEventArgs(numeroPedido, email, telefone));
    }
} 