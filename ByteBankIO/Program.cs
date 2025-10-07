using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        // LidandoComFileStreamDiretamente();
        // UsandoStreamReader();

        try
        {
            // CriarArquivo();
            // CriarArquivoComWriter();
            // CriarArquivoComWriteLine();
            //EscritaBinaria();
            LeituraBinaria();

            Console.WriteLine("Atividades realizadas com sucesso.");

        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar ao arquivo" + ex.ToString());
        }


        Console.WriteLine();
        Console.Write("Pressione enter para sair");
        Console.ReadLine();
    }

}