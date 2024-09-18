using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite sua nota: ");
		int nota = int.Parse(Console.ReadLine());
		
		if(nota >= 10){
			Console.WriteLine("O aluno aprovado com {0} de nota!", nota);
		}else if(nota >= 5){
			Console.WriteLine("O aluno está de recuperação com {0} de nota!", nota);
		}else{
			Console.WriteLine("O aluno está reprovado com {0} de nota!", nota);
		}
	}
}