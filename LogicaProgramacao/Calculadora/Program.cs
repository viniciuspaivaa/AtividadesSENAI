using System;
					
public class Program
{
	public static void Main()
	{	
		
		bool error = false;
		float calc = 0;
		
		Console.Write("Digite o primeiro número: ");
		
		if(!float.TryParse(Console.ReadLine(), out float num1)){
			Console.Write("Número inválido.");
			return;
		}
		
		Console.Write("Digite o segundo número: ");
		
		if(!float.TryParse(Console.ReadLine(), out float num2)){
			Console.Write("Número inválido.");
			return;
		}
		
		Console.WriteLine("Qual operação deseja realizar (digite o símbolo): \nAdição: +\nSubtração: -\nMultiplicação: *\nDivisão: /");
		string opera = Console.ReadLine();
		
		switch(opera){
			case "+":
				calc = num1 + num2;
				break;
			case "-":
				calc = num1 - num2;
				break;
			case "*":
				calc = num1 * num2;
				break;
			case "/":
				if(num1 == 0){
					error = true;
					break;
				}
				calc = num1 / num2;
				break;
			default:
				error = true;
				break;
		}
		
		if(!error){
			Console.Write("{0} {1} {2} = {3}", num1, opera, num2, Math.Round(calc, 2));
		} else {
			Console.Write("Operação inválida ou divisão por zero.");
		}
	}
}