ContaCorrente contaCorrente = new ContaCorrente("123456");
ContaPoupanca contaPoupanca = new ContaPoupanca("157359");
ContaEmpresarial contaEmpresarial = new ContaEmpresarial("070505");

contaCorrente.Depositar(1000);
contaPoupanca.Depositar(500);
contaEmpresarial.Depositar(5000);

contaEmpresarial.Sacar(4500);