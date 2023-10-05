using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphon Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "modelo1", imei:"111111", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphon Iphone");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "modelo2", imei:"222222", memoria: "128");
iphone.ReceberLigacao();
nokia.InstalarAplicativo("telegram");