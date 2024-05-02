using System;
using System.Text.RegularExpressions;

public class Ted : iMetodoPagamento{
    public string Conta{get;set;}

    public void RealizaPagamento(){
        if(verificaConta()){
            Console.WriteLine("Conta para transferencia Aceita!");
        }else{
            Console.WriteLine("Numero de conta para transferencia invalido!");
        }
    }

    public void Status(){
        if(verificaConta()){
            Console.WriteLine("Pagamento na transferencia recebido!");
            Console.WriteLine("Pago!");
        }else{
            Console.WriteLine("Pagamento Pendente!");
        }
    }

    public bool verificaConta(){
        if(Regex.IsMatch(Conta, @"^\d{5}-\d$")){
           return true;
        }else{
            return false;
        }
    }
}