using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia:");

Nokia SmartNokia = new Nokia(numero: "1234", modelo: "Nokia 1" , imei: "123547894", memoria: 64);
SmartNokia.Ligar();
SmartNokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

Iphone SmartIphone = new Iphone(numero: "5647", modelo: "Iphone 1" , imei: "22222222", memoria: 128);
SmartIphone.Ligar();
SmartIphone.InstalarAplicativo("Telegram");
