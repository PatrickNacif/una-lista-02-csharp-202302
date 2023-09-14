using System;

public class Program
{
  public static void Main()
  {
    double f = 0; // Declaração de variável.
    double c = 0; // Declaração de variável.

    Console.Write("Qual a valor da temperatura na escala Fahrenheit: ");
    f = double.Parse(Console.ReadLine());

    c = (double)5 / 9 * (f - 32); //formula para conversão 

    Console.Write("Temperatura convertida para Celsius é de: " + c);

    Console.ReadLine();
  }
}
