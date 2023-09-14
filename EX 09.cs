using System;

public class Program
{
  public static void Main()
  {
    Console.Write("Digite um número inteiro que representa os segundos: ");
    int segundos = Convert.ToInt32(Console.ReadLine());


    TimeSpan tempo = TimeSpan.FromSeconds(segundos);


    int horas = tempo.Hours;
    int minutos = tempo.Minutes;
    int segundos_restantes = tempo.Seconds;

    Console.WriteLine($" {horas} Horas, {minutos} Minutos e {segundos_restantes} Segundos");

    Console.ReadLine();
  }
}
