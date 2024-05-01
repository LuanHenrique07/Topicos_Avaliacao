public class ExSobrecarga{

    public void Encher(int Mililitros) {
        Console.Write($"A garrafa foi cheia com {Mililitros} Mililitros");
    }

    public void Encher(double Litros) {
        Console.Write($"A garrafa foi cheia com {Litros} Litros");
    }

    public void Encher(float Mililitros) {
        Console.Write($"A garrafa foi cheia com {Mililitros} Mililitros");
    }
}