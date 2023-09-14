using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Seja Bem-Vindo ao Sitema do Estacionamento Smarth!");

    Console.Write("Digite o total de veículos presentes no estacionamento: ");
    int total_veiculos = int.Parse(Console.ReadLine());

    Console.Write("Qual o total de rodas no estacionemento: ");
    int total_rodas = int.Parse(Console.ReadLine());

    int carros = total_rodas / 4; //calculo para saber quantos carros

    int motos = (total_rodas - (carros * 4)) / 2; //calculo para saber quantas rodas

    Console.WriteLine($"No estacionamento, há {carros} carros e {motos} motos.");

    Console.ReadLine();
  }
}
