namespace fundamentos;

public class TratandoDataEHora
{
    /*
     * Struct DateTime
     * - Represnta um momento no tempo expresso como uma 'data e hora'
     * - Uma variável do tipo DateTime é um 'tipo de valor' e possui
     * um 'valor' padrão
     * - O valor padrão de um DateTime é: 01/01/0001 00:00:00
     * - Ao usar DateTime, a representação para o português do Brasil
     * usa o formato: DD/MM/AAAA hh:mm:ss
     */
    public void MostraDataEHora()
    {
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine($"Data atual: {dataAtual}");

        //Criando uma data específica: AAAA/MM/DD
        DateTime dataEspecifica = new DateTime(2023, 10, 30);
        Console.WriteLine($"Data específica: {dataEspecifica}");

        //Definindo as horas
        DateTime dataEspecificaComHoras = new DateTime(2023, 10, 30, 10, 30, 0);
        Console.WriteLine($"Data específica com horas: {dataEspecificaComHoras}");

        /*Podemos manipular as tadas também*/
        string dataSring = "28/02/2025";
        DateTime dataConvertida;
        DateTime.TryParse(dataSring, out dataConvertida);

        Console.WriteLine($"Data Convertida: {dataConvertida}");
        Console.WriteLine($"Data convertida + 10 dias: {dataConvertida.AddDays(10)}");
        Console.WriteLine($"Data convertida - 10 dias: {dataConvertida.AddDays(-10)}");
        Console.WriteLine($"Data convertida + 10 horas: {dataConvertida.AddHours(10)}");
        Console.WriteLine($"Data convertida - 10 horas: {dataConvertida.AddHours(-10)}");
        Console.WriteLine($"Data convertida + 10 minutos: {dataConvertida.AddMinutes(10)}");
        // dia ano, semana
        Console.WriteLine($"Dia da semana: {dataConvertida.DayOfWeek}");
        Console.WriteLine($"Dia do ano: {dataConvertida.DayOfYear}");
        Console.WriteLine($"Dia da semana: {dataConvertida.DayOfWeek}");
    }
}