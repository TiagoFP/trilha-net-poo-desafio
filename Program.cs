using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "55446699", modelo: "13", imei: "1111111", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("-------------------------------");

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "22665588", modelo: "6120", imei: "2222222", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");