using System;
public class Program
{
  public static void Main()
  {
    double preco_produto, preco_percentual; // Declaração de variável.
    Console.WriteLine("Digite o preço do produto?: ");
    preco_produto = Convert.ToDouble(Console.ReadLine());

    double preco_percentural = (preco_produto / 100) * 10 + preco_produto;

    Console.WriteLine("O valor do produto com percentual de 10% a mais é: R$ " + preco_percentural.ToString("F2")); // Apresentação do resultado. (F2 formatação em 2 casas decimais)

    Console.ReadLine();
  }
}
