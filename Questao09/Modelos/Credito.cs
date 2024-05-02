public class Credito : iMetodoPagamento{
    public string Bandeira{get;set;}
    
    public bool RealizaPagamento(){
        if(verificaBand()){
            Console.WriteLine($"Pagamento sendo Processado no Cartao {Bandeira}...");
            return true;
        }else{
            Console.WriteLine($"Pagamento nao pode ser processado no Cartao {Bandeira}");
            return false;
        }
    }

    public void Status(){
        if(verificaBand()){
            Console.WriteLine($"Compra Aprovada no cartao {Bandeira}!");
            Console.WriteLine("Pago!");
        }else{
            Console.WriteLine($"Compras na {Bandeira} nao sao autorizadas!");
            Console.WriteLine("Pendente!");
        }
    }

    public bool verificaBand(){
        if(Bandeira == "MasterCard"){
            return true;
        }else{
            return false;
        }
    }
}