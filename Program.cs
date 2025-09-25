using DesafioPOO.Models;

Console.Clear();
Console.WriteLine("Nokia 110");
Smartphone nokia = new Nokia(numero:"987654321", modelo:"Nokia 110 4G", imei:"753198246", memoria:16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine();
Console.WriteLine("iPhone 17");
Smartphone iphone = new Iphone(numero:"123456789", modelo:"iPhone 17", imei:"753914682", memoria:32);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine();