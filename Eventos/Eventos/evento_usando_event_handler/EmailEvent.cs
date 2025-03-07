namespace Eventos.classes;

public class EmailEvent
{
    public static void EnviaEmail(object sender, EventArgs e)
    {
        Console.WriteLine($"📧 Enviando email para ");
    }
}
