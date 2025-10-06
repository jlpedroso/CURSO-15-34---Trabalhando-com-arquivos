using ByteBankIO;
using System.Data;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLIdos = -1;

            var buffer = new byte[1024];     // 1kb   

            while (numeroDeBytesLIdos != 0)
            {
                numeroDeBytesLIdos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreveBuffer(buffer, numeroDeBytesLIdos);
            }

            fluxoDoArquivo.Close();
        }

    }

    static void EscreveBuffer(byte[] buffer, int bytesLidos)
    {
        //foreach (byte b in buffer) 
        //{
        //    Console.Write(b);
        //    Console.Write(" ");
        //}

        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);
    }

}