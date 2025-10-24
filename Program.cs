using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia c1 = new Nokia("971193849", "Antiago", "no001", 5215);
c1.Ligar();
c1.ReceberLigacao();
c1.InstalarAplicativo("Whatzap");

Iphone c2 = new Iphone("971193845", "Recente", "no002", 5214);
c1.Ligar();
c2.ReceberLigacao();
c2.InstalarAplicativo("Google");