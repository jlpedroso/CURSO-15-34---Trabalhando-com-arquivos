
using ByteBankIO;

partial class Program
{
    static void UsandoStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
    //            var linha = leitor.ReadLine();

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"Conta número {contaCorrente.Numero} - ag {contaCorrente.Agencia} - Titular {contaCorrente.Titular.Nome} - Saldo {contaCorrente.Saldo}";

                Console.WriteLine(msg);
            }
        }
    }
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(","); // AO CONTRARIO DO ARQUIVO DA INSTRUTORA, AQUI ELE JÁ ESTAVA COM VÍRGULA

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace(".", ",");
        var nome = campos[3];

        int agenciaInt = int.Parse(agencia);
        int numeroInt = int.Parse(numero);
        double saldoDouble = double.Parse(saldo);

        Cliente titular = new Cliente();

        titular.Nome = nome;

        ContaCorrente contaCorrente = new ContaCorrente(agenciaInt, numeroInt);
        contaCorrente.Depositar(saldoDouble);
        contaCorrente.Titular = titular;

        return contaCorrente;
    }

}

