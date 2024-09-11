using DesafioPOO.Models;
using System.Text;

Iphone iphoneXr = new Iphone("8599964654", "iphoneXr", "0145601065", 32);
Nokia nokia = new Nokia("8599964154", "Nokia 5", "5511000005", 128);

iphoneXr.Ligar();
nokia.ReceberLigacao();

Console.WriteLine($"Modelo: {iphoneXr.Modelo}, IMEI: {iphoneXr.Imei}");
Console.WriteLine($"Modelo: {nokia.Modelo}, IMEI: {nokia.Imei}");

iphoneXr.InstalarAplicativo("facebook");
nokia.InstalarAplicativo("Instagram");

