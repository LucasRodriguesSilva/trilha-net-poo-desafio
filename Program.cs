using DesafioPOO.Models;

// Implementado!
Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia("(11) 90000-0000", "Nokia G11 Plus", "123456789012345,", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("IPHONE");
Smartphone iphone = new Iphone("(11) 90000-0001", "Iphone 15 Pro Max", "234567890123456,", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Minecraft");