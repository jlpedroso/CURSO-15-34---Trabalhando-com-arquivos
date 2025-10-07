partial class Program
{
    static void EscritaBinaria()
    {
        var caminhoNovoArquivo = "contasBinarias.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new BinaryWriter(fluxoDeArquivo))
        {
            escritor.Write(236);
            escritor.Write(65321);
            escritor.Write(4565.41);
            escritor.Write("Jose Luis");
        }
    }

    static void LeituraBinaria()
    {
        var enderecoDoArquivo = "contasBinarias.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        using (var leitor = new BinaryReader(fluxoDeArquivo))
        {
            var agencia = leitor.ReadInt32();
            var conta = leitor.ReadInt32(); 
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"Titular: {titular}: {agencia}/{conta} - {saldo}");
            
        }
    }


}