using Class.Banco;
using Class.Client;


class Program
{
    static void Main(string[] args)
    {

        var banco = new Banco("Banco");
        var cliente = new Cliente("Yollanda", 21, 150.00, 50.00);

        banco.SacarDinheiro(cliente, 100.00);

    }
}
