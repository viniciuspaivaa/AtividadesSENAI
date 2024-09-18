using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite o número que deseja saber a tabuada: ");
		
		if(int.TryParse(Console.ReadLine(), out int num)){
			int i = 1;
			
			while(i < 11){
				string mult = $"{num} x {i} = {num * i}";
				string div = $"{num} / {i} = {num / i}";
				string plus = $"{num} + {i} = {num + i}";
				string min = $"{num} - {i} = {num - i}";
				
				Console.Write($"{mult.PadRight(15)}");
				Console.Write($"{div.PadRight(15)}");
				Console.Write($"{plus.PadRight(15)}");
				Console.Write($"{min.PadRight(15)}\n");
				i++;
			}
		} else {
			Console.Write("O valor não é um número!");
		}
	}
}