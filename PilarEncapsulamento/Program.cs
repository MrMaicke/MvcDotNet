public class ContaBancaria
{
    // propriedade que só existe no seu contexto de criação - Classe
    private decimal saldo;

    // propriedade que pode ser acessada fora do contexto criação, mas que tenha uma relação direta - Classes Filhas
    protected decimal poupanca;

    public void Depositar(decimal dinheiro)
    {
        saldo += dinheiro;
        // saldo = saldo + dinheiro;
    }

    public void Saque(decimal dinheiro)
    {
        saldo -= dinheiro;
        // saldo = saldo + dinheiro;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine(saldo);
    }
}

public class ContaDigital : ContaBancaria
{
    public void GuardarDinheiroPoupanca(decimal dinheiro)
    {
        poupanca += dinheiro;
    }
}

// CONFIGURAÇÃO PADRÃO
class Program
{
    public class Main()
    {
        ContaBancaria conta = new ContaBancaria();
        //conta.saldo = 5.99;
    }
}