
namespace Class.Client {
    public class Cliente
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public double Saldo { get; set; }

        public double Fatura { get; set; }

        public Cliente(string Nome, int Idade, string Saldo, string Fatura)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Saldo = Saldo;
            this.Fatura = Fatura;
        }
    }
}
