using System;
					
public class Program
{
	public static void Main()
	{
		//Inclui classe Random
		Random random = new Random();
		//Variáveis que requerem escopo global
		int[] sorteios = null;
		string[] sorteiosStr = null;
		string resultado = "";
		string total = "";
		bool sucesso = false;
		int qntd = 0;
		
		//Recebe o valor do prêmio com tratamento de erros, após a saída no console
		Console.Write("Informe o valor do prêmio: ");
		if(!double.TryParse(Console.ReadLine(), out double premio)){
			Console.Write("Número inválido! Por favor, tente informar o número novamente.");
			return;
		}
		
		//Recebe a quantidade de jogos, com tratamento de erros, após a saída no console
		Console.Write("Digite os jogos deseja fazer: ");
		if(!int.TryParse(Console.ReadLine(), out int jogos) || jogos < 1){ //Requer que digite um número válido (tratamento de erro e que não pode ser inferior a 1 (-2, -1, 0, ...)
			Console.Write("Número inválido! Por favor, tente informar o número novamente.");
			return;
		}
		
		//Recebe o número de casas de cada jogo, com DO WHILE que pergunta o valor de casas enquanto este seja superior a 6 e inferior a 15, com tratamento de erros
		Console.Write("Digite quantas casas quer fazer neste jogo (mín: 6 e máx: 15): ");
		do{
			if(!int.TryParse(Console.ReadLine(), out qntd) || qntd < 6 || qntd > 15){
				Console.Write("Número inválido! Por favor, tente informar o número novamente.");
			}else{
				sorteios = new int[qntd];
				sorteiosStr = new string[qntd];
				sucesso = true;
			}
		}while(!sucesso);
		
		//Laço de repetição para gerar cada dezena de cada jogo
		for(int z = 0; z < jogos; z++){
			for(int i = 0; i < qntd; i++){
				sorteios[i] = random.Next(1, 60);
				sorteiosStr[i] = sorteios[i].ToString("D2");
				resultado = String.Join(" - ", sorteiosStr);
			}
			//Variável do tipo STRING para armazenar os resultados
			total = total + resultado + "\n";
		}
		
		//Exibe os números armazenados na variável total, que contém todos os números
		Console.Write($"\n{total}");
		
		//Exibe o valor do prêmio de acordo com as porcentagens
		Console.WriteLine($"\nO valor do prêmio será:\n75%: R${premio*0.75:F2}\n15%: R${premio*0.15:F2}\n10%: R${premio*0.1:F2}\n");
	}
}
