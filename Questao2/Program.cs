Credito compraCredito = new Credito("Luan", 19, "123456789", 130.50);
Debito compraDebito = new Debito("Luan", 19, "123456789", 199.99);
Pix compraPix = new Pix("Luan", 19, "123456789", 240);

compraCredito.Confirmacao();
compraDebito.Confirmacao();
compraPix.Confirmacao();