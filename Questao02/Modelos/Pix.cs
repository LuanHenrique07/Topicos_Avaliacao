public class Pix : IProcessarPag{
    private string Nome{get; set;}
    private int Idade {get; set;}
    private string CPF {get; set;}
    private double Valor {get; set;}

    public Pix(string Nome, int Idade, string CPF, double Valor){
        this.Nome = Nome;
        this.Idade = Idade;
        this.CPF = CPF;
        this.Valor = Valor;
    }

    public void Confirmacao(){
        Console.WriteLine($"Parabéns {Nome}!! Seu pagamento de R${Valor} foi processado no Pix e suas compras em breve chegarão!!");
    }
}