using System;

public class Program
{
  public static void Main()
  {
    Console.Write("Digite o número: ");
    double numero = double.Parse(Console.ReadLine());

    Console.Write("Digite a base do logaritmo: ");
    double baseLog = double.Parse(Console.ReadLine());

    double resultado = Math.Log(numero, baseLog);

    Console.WriteLine($"O logaritmo de {numero} na base {baseLog} é igual a {resultado:F4}");

    Console.ReadLine();
  }
}
