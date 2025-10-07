

using System.Text;

partial class Program { 
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create)) 
        {
            var contaComoString = "456, 7895, 4785.56, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes,0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadasComWriter.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            var contaComoString = "4156, 7895, 14785.56, Gustavo Santos";
            escritor.Write(contaComoString);
        }
    }

    static void CriarArquivoComWriteLine()
    {
        var caminhoNovoArquivo = "contasExportadasComWriteLine.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(454545);
        }
    }

}
