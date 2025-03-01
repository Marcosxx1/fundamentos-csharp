namespace fundamentos
{
    public class TiposNumericosIntegrais
    {
        public void MostraNumericosIntegrais()
        {
            byte valorByte = 255;
            sbyte valorSbyte = -127;
            int valorInt = -2147483647;
            uint valorUint = 214748367;
            long valorLong = 2147483489;
            ulong valorUlong = 2147483489;

            Console.WriteLine("Tipos numéricos Integrais");

            Console.WriteLine($"byte: {valorByte}");
            Console.WriteLine($"sbyte: {valorSbyte}");
            Console.WriteLine($"int: {valorInt}");
            Console.WriteLine($"uint: {valorUint}");
            Console.WriteLine($"long: {valorLong}");
            Console.WriteLine($"ulong: {valorUlong}");
            Console.WriteLine();
        }
    }
}