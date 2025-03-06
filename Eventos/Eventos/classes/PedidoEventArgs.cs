namespace Eventos.classes;

public class PedidoEventArgs : EventArgs
{
    public string NumeroPedido { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public PedidoEventArgs(string numeroPedido, string email, string telefone)
    {
        NumeroPedido = numeroPedido;
        Email = email;
        Telefone = telefone;
    }
}