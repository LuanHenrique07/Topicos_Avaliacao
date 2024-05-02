public class GruposGrandes{

     public string Destino{get; set;}
    public bool Disponivel {get;set;}
    public bool ReservaFeita;

    public GruposGrandes(string Destino, bool Disponivel){
        this.Destino = Destino;
        this.Disponivel = Disponivel;
    }
    public bool Reserva(){
        if(Verificacao()){
            Console.WriteLine("------Verificacao GG------");
            Console.WriteLine($"A viagem para o destino {Destino} ainda tem reservas disponiveis!");
            Console.WriteLine($"A reserva de seu Grande Grupo para Grupos Grandes foi feita para a viagem com destino a {Destino}!");
            return ReservaFeita = true;
        }else{
            Console.WriteLine("------Verificacao GG------");
            Console.WriteLine($"A viagem para o destino {Destino} nao tem reservas disponiveis!");
            Console.WriteLine($"Infelizmente A reserva de seu Grande Grupo para Grupos Grandes nao foi feita para a viagem com destino a {Destino}!");
            Console.WriteLine("Tente novamente mais tarde!");
            return ReservaFeita = false;
        }
    }

    public void Cancelar(){
        if(ReservaFeita){
            Console.WriteLine("------Cancelamento GG------");
            Console.WriteLine($"A reserva de seu Grande Grupo para a viagem com destino a {Destino} foi cancelada!");
            ReservaFeita = false;
        }else{
            Console.WriteLine("------Cancelamento GG------");
            Console.WriteLine($"A reserva de seu Grande Grupo para o voo a {Destino} ainda nao foi feita, impossivel cancelar!");
        }
    }

    public void Status(){
        if(ReservaFeita){
            Console.WriteLine("------Status GG------");
            Console.WriteLine($"A reserva de seu Grande Grupo para {Destino} esta Aprovada!");
        }else{
            Console.WriteLine("------Status GG------");
            Console.WriteLine($"A reserva de seu Grande Grupo para {Destino} esta Pendente ou foi Cancelada!");
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