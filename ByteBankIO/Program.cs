partial class Program
{
    static void Main(string[] args)
    {
        // LidandoComFileStreamDiretamente();

        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open)) 
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            //            var linha = leitor.ReadLine();

            while (!leitor.EndOfStream) 
            {
                Console.WriteLine(leitor.ReadLine());
            }
        }

        Console.WriteLine();
        Console.Write("Pressione enter para sair");
        Console.ReadLine();

        
    }

}