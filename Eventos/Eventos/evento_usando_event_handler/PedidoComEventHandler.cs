using System.Runtime.CompilerServices;

namespace Eventos.evento_usando_event_handler;

public class PedidoComEventHandler
{
    public EventHandler? PedidoCriado;

    public  void CriarPedido()
    {
        Console.WriteLine("\nPedido Criado!");
            PedidoCriado?.Invoke(this, EventArgs.Empty);

    }
}