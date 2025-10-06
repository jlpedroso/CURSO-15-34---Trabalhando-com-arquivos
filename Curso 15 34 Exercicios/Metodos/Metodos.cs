using System.Text;

namespace ExerciciosC_15_34.Metodos;

internal class Metodos
{
    public static void LerArquivoTexto01()
    {
        // METODO PARA TESTAR O EXERCICIO 09 DA AULA 1
        var fs = new FileStream("c:/temp/teste.txt", FileMode.Open);

        var buffer = new byte[1024];
        var encoding = Encoding.ASCII;

        var bytesLidos = fs.Read(buffer, 0, 1024);
        var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

        Console.Write(conteudoArquivo);
    }
}

