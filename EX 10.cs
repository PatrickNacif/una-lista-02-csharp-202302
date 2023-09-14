using System;

public class Program
{
  public static void Main()
  {
    Console.Write("Digite o pirmeiro valor: ");
    double valor = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    double valor2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o terceiro valor: ");
    double valor3 = Convert.ToDouble(Console.ReadLine());

    //Calculo das Médias

    double media_harmonica = 3 / ((1 / valor) + (1 / valor2) + (1 / valor3));
    double media_geometrica = Math.Pow(valor * valor2 * valor3, 1.0 / 3.0);
    double media_aritmetica = (valor + valor2 + valor3) / 3;

    // Apresentação do resultado, Com formatação na segunda casa decimal ("F2").

    Console.WriteLine("A Média Geométrica é: " + media_geometrica.ToString("F2"));
    Console.WriteLine("A média Harmônica é: " + media_harmonica.ToString("F2"));
    Console.WriteLine("A Média Aritmética é : " + media_aritmetica.ToString("F2"));

    Console.ReadLine();
  }
}
