public class ReservaUP{
        public string Destino{get; set;}
    public bool Disponivel {get;set;}
    public bool ReservaFeita;

    public ReservaUP(string Destino, bool Disponivel){
        this.Destino = Destino;
        this.Disponivel = Disponivel;
    }
    public bool Reserva(){
        if(Verificacao()){
            Console.WriteLine("------Verificacao UP------");
            Console.WriteLine($"A viagem para o destino {Destino} ainda tem reservas disponiveis!");
            Console.WriteLine($"Sua Reserva com Upgrade de classe foi feita para a viagem com destino a {Destino}!");
            return ReservaFeita = true;
        }else{
            Console.WriteLine("------Verificacao UP------");
            Console.WriteLine($"A viagem para o destino {Destino} nao tem reservas disponiveis!");
            Console.WriteLine($"Infelizmente sua Reserva com Upgrade de classe nao foi feita para a viagem com destino a {Destino}!");
            Console.WriteLine("Tente novamente mais tarde!");
            return ReservaFeita = false;
        }
    }

    public void Cancelar(){
        if(ReservaFeita){
            Console.WriteLine("------Cancelamento UP------");
            Console.WriteLine($"Sua Reserva com Upgrade para a viagem com destino a {Destino} foi cancelada!");
            ReservaFeita = false;
        }else{
            Console.WriteLine("------Cancelamento UP------");
            Console.WriteLine($"Sua reserva com Upgrade para o voo a {Destino} ainda nao foi feita, impossivel cancelar!");
        }
    }

    public void Status(){
        if(ReservaFeita){
            Console.WriteLine("------Status UP------");
            Console.WriteLine($"Sua Reserva com Upgrade para {Destino} esta Aprovada!");
        }else{
            Console.WriteLine("------Status UP------");
            Console.WriteLine($"Sua Reserva com Upgrade para {Destino} esta Pendente ou foi Cancelada!");
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