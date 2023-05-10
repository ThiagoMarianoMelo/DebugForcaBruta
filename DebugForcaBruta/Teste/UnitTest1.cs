

using Class.Banco;
using Class.Client;

namespace Teste
{
    public class UnitTest1
    {

        [Fact]
        public void TesteDepositarDinheiro()
        {
            var banco = new Banco("Banco X");
            var cliente = new Cliente("Thiago", 19, 200.00, 0.0);
            Assert.Equal(220.00, banco.DepositarDinheiro(cliente, 20));
        }

        [Fact]
        public void TesteSacarDinheiro()
        {
            var banco = new Banco("Banco Y");
            var cliente = new Cliente("Felipe", 20, 200.00, 100.0);
            Assert.Equal(80.00, banco.SacarDinheiro(cliente, 120.00));
        }
    }
}