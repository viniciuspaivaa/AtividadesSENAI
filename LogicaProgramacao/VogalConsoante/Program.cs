using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite uma letra: ");
		string input = Console.ReadLine();
		int i;
		
		if(int.TryParse(input, out i) || input.Length > 1){
			Console.Write("Digite uma letra!");
		}else{
			char lett = input[0];
			
			if(lett == 'a' || lett == 'e' || lett == 'i' || lett == 'o' || lett == 'u'){
				Console.Write($"A letra {lett} é uma vogal!");
			}else{
				Console.Write($"A letra {lett} é uma consoante!");
			}
		}
	}
}
