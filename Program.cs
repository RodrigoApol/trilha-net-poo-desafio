using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new(numero: "(51) 98888-8888", modelo: "X1-01", imei: "21248484", memoria: 64);
Iphone iphone = new("(51) 97777-7777", "5s", "555115115", 128);

// Métodos em comum
nokia.Ligar();
iphone.Ligar();
Console.WriteLine("");
nokia.ReceberLigacao();
iphone.ReceberLigacao();
Console.WriteLine("");

// Métodos sobrescritos
nokia.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("HBO Max");
Console.WriteLine("");