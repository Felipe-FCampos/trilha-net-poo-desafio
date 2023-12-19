using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//IMPLEMETADO

Console.Clear();
Console.WriteLine("\nEsse é o smartphone: Nokia");
Smartphone nokia = new Nokia(numero:"999999999", modelo:"1", imei:"11111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Esse é o smartphone: Iphone");
Smartphone iphone = new Iphone(numero:"910987654", modelo:"2", imei:"22222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

