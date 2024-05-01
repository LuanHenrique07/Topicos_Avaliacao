3. Diferencie sobrecarga e sobreposição (ou sobrescrita) e forneça exemplos de
cada um em C#.

Resposta:
    Sobrecarga: Uma sobrecarga de métodos é ter vários métodos com o mesmo nome, porém cada um recebendo parametros diferentes, assim como fiz no exemplo.
    Sobreescrita: Na sobreescrita se utiliza uma herança, assim na classe-Pai criando um método virtual, podendo ser sobreescrito na Classe-Filho utilizando o override.

Prompt ->
Foi utilizado um prompt pois eu nao estava conseguindo imprimir os diferentes tipos de metodos da sobrecarga:

    Pedido -> 
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

    como rodar os 3 metodos?

    Resposta ->
    Para rodar os três métodos da classe ExSobrecarga, você pode criar uma instância da classe e chamar cada um dos métodos. Aqui está um exemplo de como fazer isso em C#:

        class Program
    {
        static void Main(string[] args)
        {
            ExSobrecarga sobrecarga = new ExSobrecarga();

            sobrecarga.Encher(500); // Chama o método Encher(int Mililitros)
            sobrecarga.Encher(0.5); // Chama o método Encher(double Litros)
            sobrecarga.Encher(250.5f); // Chama o método Encher(float Mililitros)
        }
    }

