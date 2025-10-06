using ByteBankIO;
using System.Data;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo,FileMode.Open);
        var numeroDeBytesLIdos = -1;

        var buffer = new byte[1024];     // 1kb   

        while (numeroDeBytesLIdos != 0) 
        { 
            numeroDeBytesLIdos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreveBuffer(buffer);
        }

        Console.WriteLine();
        Console.Write("Pressione enter para sair");
        Console.ReadLine();

        
    }

    static void EscreveBuffer(byte[] buffer) 
    {
        //foreach (byte b in buffer) 
        //{
        //    Console.Write(b);
        //    Console.Write(" ");
        //}

        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer);
        Console.Write(texto);



    }

}