Credito compra1 = new Credito();

compra1.Bandeira = "MasterCard";
compra1.RealizaPagamento();
compra1.Status();
Console.WriteLine();

Boleto compra2 = new Boleto();
compra2.NumBoleto = "1234567891";
compra2.RealizaPagamento();
compra2.Status();
Console.WriteLine();

Ted compra3 = new Ted();
compra3.Conta = "12345-7";
compra3.RealizaPagamento();
compra3.Status();