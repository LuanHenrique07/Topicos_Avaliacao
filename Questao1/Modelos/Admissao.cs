public class Admissao : Funcionarios{
    public DateTime DataAdmissao { get; set; }

    public Admissao(string Nome, string CPF, int Idade, string CodigoFuncionario){
        this.Nome = Nome;
        this.CPF = CPF;
        this.Idade = Idade;
        this.DataAdmissao = DateTime.Now;
    }

    public void ExibirDetalhes(){
        Console.WriteLine($"Nome do funcionario: {Nome}, CPF: {CPF}, Idade: {Idade}, foi admitido em: {DataAdmissao}");
    }
}