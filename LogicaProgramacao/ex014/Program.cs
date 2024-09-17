using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite a distância em metros: ");
		
		if(!double.TryParse(Console.ReadLine(), out double m)){
			Console.Write("Digite um número!");
			return;
		}
		
		double cm = m * 100;
		double km = m / 1000;
		double mi = m / 1609;
		
		Console.Write("Escolha a unidade de conversão (cm, km, mi): ");
		string distan = Console.ReadLine().ToLower();
		
		switch(distan){
			case "cm":
				Console.Write($"Resultado: {Math.Round(cm, 3)} cm");	
				break;
			case "km":
				Console.Write($"Resultado: {Math.Round(km, 3)} km");	
				break;
			case "mi":
				Console.Write($"Resultado: {Math.Round(mi, 3)} mi");	
				break;
			default:
				Console.Write("Digite um valor válido!");
				break;
		}
	}
}