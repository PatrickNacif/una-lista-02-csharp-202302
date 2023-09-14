using System;

public class Program
{
  public static void Main()
  {
    double capital, taxa_juros, montante; // Declaração de variável.
    int prazo_meses; // Declaração de variável.

    Console.Write("Informe o valor do capital a ser aplicado: R$ ");
    capital = Convert.ToDouble(Console.ReadLine());

    Console.Write("Qual o prazo da aplicação em meses?: ");
    prazo_meses = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informar a taxa de juros mensais (em %): ");
    taxa_juros = Convert.ToDouble(Console.ReadLine());

    taxa_juros = taxa_juros / 100;

    montante = capital * Math.Pow(1 + taxa_juros, prazo_meses);

    Console.WriteLine("O montante do valor a ser recebido é de: R$ " + montante.ToString("F2"));

    Console.ReadLine();
  }
}
