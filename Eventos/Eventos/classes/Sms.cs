namespace Eventos.classes;

public class Sms
{
    public static void EnviaSms(object sender, PedidoEventArgs e)
    {
        Console.WriteLine($"📲 Enviando SMS para {e.Telefone} sobre o pedido {e.NumeroPedido}");
    }
}