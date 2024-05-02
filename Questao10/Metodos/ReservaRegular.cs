public class ReservaRegular{
    public string Destino{get; set;}
    public bool Disponivel {get;set;}
    public bool ReservaFeita;

    public ReservaRegular(string Destino, bool Disponivel){
        this.Destino = Destino;
        this.Disponivel = Disponivel;
    }
    public bool Reserva(){
        if(Verificacao()){
            Console.WriteLine("------Verificacao Regular------");
            Console.WriteLine($"A viagem para o destino {Destino} ainda tem reservas disponiveis!");
            Console.WriteLine($"Sua Reserva Regular foi feita para a viagem com destino a {Destino}!");
            Console.WriteLine();
            return ReservaFeita = true;
        }else{
            Console.WriteLine("------Verificacao Regular------");
            Console.WriteLine($"A viagem para o destino {Destino} nao tem reservas disponiveis!");
            Console.WriteLine($"Infelizmente sua Reserva Regular nao foi feita para a viagem com destino a {Destino}!");
            Console.WriteLine("Tente novamente mais tarde!");
            return ReservaFeita = false;
        }
    }

    public void Cancelar(){
        if(ReservaFeita){
            Console.WriteLine("------Cancelamento Regular------");
            Console.WriteLine($"Sua Reserva para a viagem com destino a {Destino} foi cancelada!");
            ReservaFeita = false;
        }else{
            Console.WriteLine("------Cancelamento Regular------");
            Console.WriteLine($"Sua reserva para o voo a {Destino} ainda nao foi feita, impossivel cancelar!");
        }
    }

    public void Status(){
        if(ReservaFeita){
            Console.WriteLine("------Status Regular------");
            Console.WriteLine($"Sua Reserva para {Destino} esta Aprovada!");
        }else{
            Console.WriteLine("------Status Regular------");
            Console.WriteLine($"Sua Reserva para {Destino} esta Pendente ou foi Cancelada!");
        }
    }

    public bool Verificacao(){
        if(Disponivel == true){
            return true;
        }else{
            return false;
        }
    }
}