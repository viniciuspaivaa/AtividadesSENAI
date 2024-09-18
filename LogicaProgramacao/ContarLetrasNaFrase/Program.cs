using System;

public class Program
{
	public static void Main()
	{	
		Console.Write("Digite uma frase: ");
		string phr = Console.ReadLine();
		phr = phr.ToLower();
		
		Console.Write("Escolha uma palavra para buscar: ");
		char lett = Console.ReadLine()[0];
		
		int count = 0;
		
		foreach(char i in phr)
		{
			if(i == lett){count ++;}
		}
		
		Console.Write($"Há {count} letras '{lett}' na frase!");
	}
}