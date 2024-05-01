public class ContaCorrente : Banco {

    public double Valor {get; set;}
    public double Saldo {get; set;}
    
    public ContaCorrente(string NumeroConta){
        this.NumeroConta = NumeroConta;
    }

    public override void Depositar(double Valor)
    {
        Saldo += Valor;
        Console.WriteLine("Deposito no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
        Console.WriteLine("Deposito feito na Conta Corrente.");
        Console.WriteLine("O saldo resultante é: " + Saldo);
    }

    public override void Sacar(double Valor)
    {
        if (Saldo > Valor)
        {
            Saldo -= Valor;
             Console.WriteLine("Saque no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
            Console.WriteLine("Saque feito na Conta Corrente.");
            Console.WriteLine("O saldo resultante é: " + Saldo);
        }else{
            Console.WriteLine("Negado, seu Saldo é: " + Saldo);
        }
    }
}