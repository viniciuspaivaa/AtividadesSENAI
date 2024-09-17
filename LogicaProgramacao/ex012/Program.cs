using System;
					
public class Program
{
	public static void Main()
	{
		Random random = new Random();
		int randomNum = random.Next(1, 100);
		
		Console.Write("Digite um número: ");
		int num = int.Parse(Console.ReadLine());
		
		int count = 0;
		
		do{
			if(num < randomNum){
				Console.Write("Número muito baixo, tente novamente: ");
				num = int.Parse(Console.ReadLine());
			} else {
				Console.Write("Número muito alto, tente novamente: ");
				num = int.Parse(Console.ReadLine());
			}
			
	        count++;
		}while(num != randomNum);
		
		Console.Write($"Parabéns, você acertou o número {randomNum} com {count} tentativas!");
	}
}