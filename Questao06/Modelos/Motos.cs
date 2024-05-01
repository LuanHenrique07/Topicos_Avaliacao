public class Motos : Veiculos{
    public double CC {get; set;}

    public Motos(string Marca, string Modelo, int CC){
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.CC = CC;
    }

    public void ExibirInfos(){
        Console.Write($"Marca: {Marca}, Modelo {Modelo}, Cilindradas {CC}");
        Console.WriteLine();
    }
}