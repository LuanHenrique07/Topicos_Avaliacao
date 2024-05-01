public class Carros : Veiculos{
    public int NumPortas {get;set;}

    public Carros(string Marca, string Modelo, int NumPortas){
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.NumPortas = NumPortas;
    }

    public void ExibirInfos(){
        Console.Write($"Marca: {Marca}, Modelo {Modelo}, Numero de Portas {NumPortas}");
        Console.WriteLine();
    }
}