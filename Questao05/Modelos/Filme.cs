public class Filme{
    public string Titulo {get; set;}
    public string Genero {get;set;}
    public double Duracao {get;set;}
    public bool Disponivel {get;set;}

    public Filme(string Titulo, string Genero, double Duracao, bool Disponivel){
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.Duracao = Duracao;
        this.Disponivel = Disponivel;
    }

    public void Verificacao(){
        if(Disponivel == true){
            Console.WriteLine($"O Filme {Titulo} esta disponível");
        }else{
            Console.WriteLine($"O Filme {Titulo} nao esta disponível");
        }
    }

    public bool Locacao(){
        Verificacao();
        Console.WriteLine($"Você locou o filme {Titulo}");

        return Disponivel = false; 
    }

    public void Devolucao(){
        Console.WriteLine();
        Console.WriteLine($"O filme {Titulo} foi devolvido!!");
        Console.WriteLine("Obrigado pela preferência!!");
        Console.WriteLine();

        Disponivel = true;
    }
}