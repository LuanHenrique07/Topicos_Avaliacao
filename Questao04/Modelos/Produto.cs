public class Produto{
    private string Nome {get; set;}
    private double PrecoEstoque {get; set;}
    private int QuantidadeEstoque {get; set;}
    private double PrecoProduto {get; set;}

    public Produto(string Nome, double PrecoProduto, int QuantidadeEstoque){
        this.Nome = Nome;
        this.PrecoProduto = PrecoProduto;
        this.QuantidadeEstoque = QuantidadeEstoque;
    }

    public void ExibirEstoque(){
        Console.WriteLine($"A quantidade em estoque do produto {Nome} é {QuantidadeEstoque} unidades!");
    }

    public void AdicionarEstoque(int Addprodutos){
        QuantidadeEstoque += Addprodutos;
        Console.WriteLine($"Após a adição ficamos com {QuantidadeEstoque} unidades do produto {Nome} em estoque!");
    }

    public void RemoverEstoque(int RemEstoque){
        QuantidadeEstoque -= RemEstoque;
        Console.WriteLine($"Removemos {RemEstoque} unidades do estoque do Produto {Nome}");
        Console.WriteLine($"Após a remoção ficamos com {QuantidadeEstoque} unidades do produto {Nome} em estoque!");
    }

    public void ValorEstoque(){
        PrecoEstoque = PrecoProduto * QuantidadeEstoque;
        Console.WriteLine($"O valor em estoque do produto {Nome} após as alterações é R${PrecoEstoque}");
    }

    public void ExibirInformacoes(){
        Console.WriteLine();
        Console.WriteLine($"----------Informacoes Produto {Nome}----------");
        ExibirEstoque();
        ValorEstoque();
        Console.WriteLine();
    }

}