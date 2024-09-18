using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite o número: ");
	
		if(int.TryParse(Console.ReadLine(), out int num)){
			if(num % 2 == 0){
				Console.Write("O número {0} é par!", num);
			} else {
				Console.Write("O número {0} é ímpar!", num);
			}
		} else {
			Console.Write("O valor não é numeral!");
		}
	}
}