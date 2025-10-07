partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("ArqConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024]; //1kb

            for (var i = 0; i < 3; i++)
            {
                Console.Write("Digite algo: ");
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();

                Console.WriteLine($"Bytes lidos na console: {bytesLidos}");
            }

        }

    }
}