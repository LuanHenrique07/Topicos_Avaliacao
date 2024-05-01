//Classe-Pai
Garrafa garrafa = new Garrafa();
garrafa.Cor();
garrafa.TamanhoG();

//Sobreescrita
ExSobreescrita ex = new ExSobreescrita();
ex.Cor();
ex.TamanhoG();

//Sobrecarga
ExSobrecarga ex2 = new ExSobrecarga();
ex2.Encher(100);//mililitros
ex2.Encher(0.2);
ex2.Encher(30.0f);

