public class ContaEmpresarial : Banco
{
    public double Saldo { get; set;}
    public double Valor {get; set;}

    public ContaEmpresarial(string NumeroConta){
        this.NumeroConta = NumeroConta;
    }

    public override void Depositar(double Valor)
    {
        Saldo += Valor;
        Console.WriteLine("Deposito no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
        Console.WriteLine("Deposito feito na Conta Empresarial.");
        Console.WriteLine("O saldo resultante é: " + Saldo);
    }
    public override void Sacar(double Valor)
    {
        if(SaldoMinimo()){
            if (Valor <= Saldo){
                Saldo -= Valor;
                 Console.WriteLine("Saque no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
                 Console.WriteLine("Saque feito na Conta Empresarial.");
                Console.WriteLine("O saldo resultante é: " + Saldo);
            }else{
                Console.WriteLine("Negado, seu Saldo é: " + Saldo);
            }
        }else{
            Console.WriteLine("Não é possível efetuar essa transação! Seu saldo ficará menor que o saldo mínimo exigido pelo Banco para contas empresariais.");
            Console.WriteLine("Saque Negado!!");
        }
    
    }

    public bool SaldoMinimo(){
        if (Saldo - Valor >= 1000)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}