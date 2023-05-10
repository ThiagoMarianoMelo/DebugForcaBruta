
using Class.Client;
namespace Class.Banco {
    public class Banco
    {
        private string nome { get; set; }

        public Banco(string Nome)
        {
            this.nome = Nome;
        }

        public double DepositarDinheiro(Cliente cliente, double dinheiro)
        {
            return cliente.Saldo += dinheiro;
        }

        public double SacarDinheiro(Cliente cliente, double dinheiro)
        {
            var saldoAtual = cliente.Fatura;
            Console.WriteLine(saldoAtual);
            if (saldoAtual <= dinheiro) return saldoAtual;
            return saldoAtual -= dinheiro;
        }
    }
}
