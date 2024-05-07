using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"(14)9989-5566",modelo:"Nokia N100", imei:"123ZYZ456ASD",memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(numero:"(14)9988-7788",modelo:"IPhone 14", imei:"456ASX456YTU",memoria:256);
iphone.InstalarAplicativo("Discord");
iphone.ReceberLigacao();
