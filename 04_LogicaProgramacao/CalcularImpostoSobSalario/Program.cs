using System;
					
public class Program
{
	public static void Main()
	{

	///Funciona apartir da versão 6.0

		Console.Write("Digite seu salário bruto: ");
	
		if(float.TryParse(Console.ReadLine(), out float salary)){
			if(salary <= 3000){
				Console.Write("O imposto será de R${0}!", Math.Round(salary * 0.1, 2));
			} else if(salary <= 6000){
				Console.Write("O imposto será de R${0}!", Math.Round(salary * 0.15, 2));
			} else {
				Console.Write("O imposto será de R${0}!", Math.Round(salary * 0.2, 2));
			}
		} else {
			Console.Write("O valor não é numeral!");
		}
	}
}

