
public class Bicicletas : Veiculos{
    public int NumMarchas {get; set;}

    public Bicicletas(string Marca, string Modelo, int NumMarchas){
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.NumMarchas = NumMarchas;
    }

    public void ExibirInfos(){
        Console.Write($"Marca: {Marca}, Modelo {Modelo}, Numero de Marchas {NumMarchas}");
        Console.WriteLine();
    }
}