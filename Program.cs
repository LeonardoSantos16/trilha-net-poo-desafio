using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", Imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone:");
Smartphone iphone = new Iphone(numero: "56313", modelo: "modelo 2", Imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");