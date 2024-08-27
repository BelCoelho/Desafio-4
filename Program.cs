using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "0987654321", modelo: "Nokinha", imei: "0987", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Buble Witch Saga\n\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "Iphonezinho", imei: "1234", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Candy Crash");
