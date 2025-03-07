namespace Eventos.classes;

public class SmsEvent
{
    public static void EnviaSms(object sender, EventArgs e)
    {
        Console.WriteLine($"📲 Enviando SMS para ");
    }
}