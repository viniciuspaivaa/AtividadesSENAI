using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite a idade do usuário: ");
		int age = int.Parse(Console.ReadLine());
		
		if(age <= 12){
			Console.WriteLine("Classificado como criança!");
		} else if(age <= 17){
			Console.WriteLine("Classificado como adolescente!");
		} else if(age <= 64){
			Console.WriteLine("Classificado como adulto!");
		} else {
			Console.WriteLine("Classificado como idoso!");
		}
	}
}