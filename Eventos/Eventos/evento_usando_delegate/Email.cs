namespace Eventos.classes;

public class Email
{
    public static void EnviaEmail(object sender, PedidoEventArgs e)
    {
        Console.WriteLine($"📧 Enviando email para {e.Email} sobre o pedido {e.NumeroPedido}");
    }
}
