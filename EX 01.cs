using System;
public class Program
{
  public static void Main()
  {
    double n1, n2, media; // Declaração de variável.
    Console.WriteLine("Digite o primeiro número: ");
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    n2 = Convert.ToDouble(Console.ReadLine());

    media = (n1 + n2) / 2;  // Calculo da média.

    Console.WriteLine("A media dos números informados é: " + media); // Apresentação do resultado.

    Console.ReadLine();
  }
}
