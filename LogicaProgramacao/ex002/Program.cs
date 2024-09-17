using System;
					
public class Program
{
	public static void Main()
	{
		int soma = 0;
		int i;
		
		for(i = 0; i < 4; i++){
			Console.Write("Digite a nota do {0}º bimestre: ", (i + 1));
			int nota = int.Parse(Console.ReadLine());
			
			soma += nota;
		}

		int media = (soma / 4);
		
		if(media>=60){
			Console.Write("Aluno aprovado com {0}!", media);
		} else if(media>=40){
			Console.Write("Aluno recuperação com {0}!", media);
		}else{
			Console.Write("Aluno reprovado com {0}!", media);	
		}
	}
}