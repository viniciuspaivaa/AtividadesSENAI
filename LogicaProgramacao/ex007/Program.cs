using System;
					
public class Program
{
	public static void Main()
	{	
		Console.Write("Digite a quantia em reais: R$");
		
		if(double.TryParse(Console.ReadLine(), out double real)){
			double dolar = Math.Round((real * 0.18), 2);
			double euro = Math.Round((real * 0.17), 2);
			double libra = Math.Round((real *0.14), 2);
			
			Console.WriteLine($"Valores convertidos de R${real:F2}: \nDólar: ${dolar:F2}\nEuro: ${euro:F2}\nLibra esterlina: ${libra:F2}");
		} else {
			Console.Write("Valor inválido.");
		}
	}
}