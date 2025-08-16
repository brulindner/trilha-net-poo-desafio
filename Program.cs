using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("99900-8588", "Modelo Nokia", "1414141", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iPhone = new Iphone("98866-5544", "Modelo iPhone", "121212", 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");

