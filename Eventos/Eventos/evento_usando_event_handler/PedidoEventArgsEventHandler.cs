namespace Eventos.evento_usando_event_handler;

public class PedidoEventArgsEventHandler : EventArgs
{
    public string NumeroPedido { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public PedidoEventArgsEventHandler(string numeroPedido, string email, string telefone)
    {
        NumeroPedido = numeroPedido;
        Email = email;
        Telefone = telefone;
    }
}