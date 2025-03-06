using Eventos.classes;

internal class Program
{
    public static void Main(string[] args)
    {
        Pedido pedido = new Pedido();
        pedido.PedidoCriado += Email.EnviaEmail;
        pedido.PedidoCriado += Sms.EnviaSms;
    }
}