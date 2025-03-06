namespace MultiCastDelegates.service;

public class UsuarioService
{
    //salvarnobanco, enviarEmail, criarLog

    public static void SalvarNoBanco(string nome)
    {
        Console.WriteLine($"Usuaário com nome: {nome}, salvo no banco!");
    }

    public static void EnviarEmail(string nome)
    {
        Console.WriteLine($"E-mail de boas vindas enviado para usuário: {nome}");
    }

    public static void CriaLog(string nome)
    {
        Console.WriteLine($"Log para criação do usuário: {nome}, criado...");
    }
}