public class Boleto : iMetodoPagamento{
    public string NumBoleto{get;set;}
    
    public bool VerificaBoleto(){
        if(NumBoleto.Length == 10){
            return true;
        }else{
            return false;
        }
    }

    public void RealizaPagamento(){
        if(VerificaBoleto()){
            Console.WriteLine("Compra sendo Processada...");
        }else{
            Console.WriteLine("Nao foi possivel encontrar seu boleto!");
        }
    }

    public void Status(){
        if(VerificaBoleto()){
            Console.WriteLine($"Compra Aprovada no boleto {NumBoleto}!");
            Console.WriteLine("Pago!");
        }else{
            Console.WriteLine($"O numero do boleto esta incorreto!");
            Console.WriteLine("Pendente!");
        }
    }

}