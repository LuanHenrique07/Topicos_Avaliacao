public class ContaPoupanca : Banco
{
    public double Saldo { get; set;}

    public ContaPoupanca(string NumeroConta){
        this.NumeroConta = NumeroConta;
    }

    public override void Depositar(double Valor)
    {
        Saldo += Valor;
        Console.WriteLine("Deposito no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
        Console.WriteLine("Deposito feito na Conta Poupança.");
        Console.WriteLine("O saldo resultante é: " + Saldo);
    }
    public override void Sacar(double Valor)
    {
        if (Valor <= Saldo)
        {
            Saldo -= Valor;
            Console.WriteLine("Saque no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
            Console.WriteLine("Saque feito na Conta Poupança.");
            Console.WriteLine("O saldo resultante é: " + Saldo);
        }
        else
        {
            Console.WriteLine("Negado, seu Saldo é: " + Saldo);
        }
    }

    public void CalculoJuros(double Saldo){
        Saldo *= 0.5;
    }
}