public class ContaEmpresarial : Banco
{
    public double Saldo { get; set;}

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
            Console.WriteLine("Seu saldo ficara menor que o saldo minimo exigido pelo Banco para contas empresariais, Saque Negado!!");
        }
    
    }

    public bool SaldoMinimo(){
        if(Saldo <= 1000){
            Console.WriteLine("Nao e possivel efetuar essa transacao!");
            return false;
        }else{
            return true;
        }
    }
}