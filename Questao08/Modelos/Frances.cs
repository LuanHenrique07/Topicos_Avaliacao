public class Frances : Cursos{
    public string Nome;
    public bool AcimaMedia;

    List<double> notas = new List<double>(); 
    
    public Frances(string Nome, string Nivel, double Duracao, bool Conclusao ){
        this.Nome = Nome;
        this.Nivel = Nivel;
        this.Duracao = Duracao;
        this.Conclusao = Conclusao;
    }

    public void ReceberNotas(){
        Console.WriteLine($"Por favor, insira as notas do aluno {Nome} (digite 'fim' para parar): ");
        while (true)
        {
            Console.Write("Nota: ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fim")
                break;
                
            if (double.TryParse(entrada, out double nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Nota inválida. Por favor, insira uma nota válida.");
            }
        }
    }

    public bool MediaNotas(){
        if(notas.Count > 0){
            double Soma = 0;
            foreach(var nota in notas){
                Soma += nota;
            }
            double Media = Soma / notas.Count;
            Console.WriteLine($"A media das notas do aluno {Nome} e {Media}");
            if(Media > 6){
                return AcimaMedia = true;
            }else{
                return AcimaMedia = false;
            }
        }else{
            Console.WriteLine("Notas ainda nao recebidas!");
            return AcimaMedia = false;
        }

    }

    public void GerarCertificado(){
        if(Conclusao && AcimaMedia){
            Console.WriteLine($"Seu Certificado de Conclusao do Curso de Frances {Nivel} foi enviado para seu Email.");
        }else{
            Console.WriteLine("Seu Curso de Frances ainda nao foi Concluido!");
        }
    }
}