using System;
public class Program
{
  public static void Main()
  {
    double salario_fixo, total_vendas, percentual_comissao, salario_total; // Declaração de variável.
    Console.WriteLine("Qual o seu salário: ");
    salario_fixo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Qual o valor total de vendas realizadas por você?: ");
    total_vendas = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Informe o percentual de comissão (ex: 10 para 10%): ");
    percentual_comissao = Convert.ToDouble(Console.ReadLine());

    double comissao = (percentual_comissao / 100) * total_vendas;

    salario_total = salario_fixo + comissao;

    Console.WriteLine("O salário total do vendedor é: R$ " + salario_total.ToString("F2")); // Apresentação do resultado. (F2 formatação em 2 casas decimais)

    Console.ReadLine();
  }
}
