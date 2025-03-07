using Eventos.classes;
using Eventos.evento_usando_event_handler;

internal class Program
{
    public static void Main(string[] args)
    {
        Pedido pedido = new Pedido();
        pedido.PedidoCriado += Email.EnviaEmail;
        pedido.PedidoCriado += Sms.EnviaSms;
        
        pedido.CriarPedido("1", "email@email.com", "214312341");
        
        PedidoComEventHandler pedidoEventHandler = new PedidoComEventHandler();
        pedidoEventHandler.PedidoCriado += EmailEvent.EnviaEmail;
        pedidoEventHandler.PedidoCriado += SmsEvent.EnviaSms;
        
        pedidoEventHandler.CriarPedido();
    }
}