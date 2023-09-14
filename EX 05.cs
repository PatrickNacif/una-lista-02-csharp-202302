using System;

public class Program
{
  public static void Main()
  {
    double salario_bruto, horas, valor_Xhoras, salario_familia, numero_filhos14; // Declaração de variável.

    Console.Write("Quantidade de horas trabalhadas no mês: ");
    horas = Convert.ToInt32(Console.ReadLine());

    Console.Write("Qual valor recebido por hora trabalhada?: ");
    valor_Xhoras = Convert.ToDouble(Console.ReadLine());

    Console.Write("Informar quantidade de numero de filhos com idade menor que 14 anos: ");
    numero_filhos14 = Convert.ToDouble(Console.ReadLine());

    salario_familia = numero_filhos14 * 48.90; // supondo que o valor por filhos menores de 14 anos sejá R$ 48,90.

    salario_bruto = valor_Xhoras * horas + salario_familia;

    Console.WriteLine("O salário bruto a ser recebido é R$ " + salario_bruto.ToString("F2"));

    Console.ReadLine();
  }
}
