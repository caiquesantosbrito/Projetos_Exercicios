using System;

namespace Projeto_Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            bool senha_valida;
            int escolha;
            int contador = 0;
            string resposta;
            
            // Dados da Passagem
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-----------Sistema de Passagens-----------");
            Console.WriteLine("-------------------------------------------");

            // Login
            do{
                Console.WriteLine("Digite a senha para acessar o sistema");
                string senha = Console.ReadLine();
                senha_valida = efetuar_login(senha);
            }
            while(!senha_valida);

            // Menu
            do{
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção a baixo");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch(escolha){
                    case 1: 
                        Console.WriteLine("Cadastrar Passageiro");
                        do{
                            if(contador < 5){
                                Console.WriteLine($"Digite o nome do {contador+1}º passageiro");
                                nomes[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite o destino"); 
                                destino[contador] = Console.ReadLine();
                                Console.WriteLine("Digite a origem");
                                origem[contador] = Console.ReadLine();
                                Console.WriteLine("Digite a data do vôo");
                                data[contador] = Console.ReadLine();
                                contador++;                              
                            }else{
                                Console.WriteLine("Limite Excedido");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar um novo passageiro? sim/nao");
                            resposta = Console.ReadLine();
                        }
                        while(resposta == "sim");
                        Console.Clear();              
                        break;

                    case 2:
                        Console.WriteLine("Listagem de Passagens");
                        for(var i = 0; i < contador; i++){
                            Console.WriteLine($"Passageiro: {nomes[i]}, Origem: {origem[i]}, Destino: {destino[i]}, Data do vôo: {data[i]}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por viajar na oKaiiN's Airline");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;            
                }
            }
            while(escolha != 0);

            // Funções
            bool efetuar_login(string senha){
                if(senha == "123456"){
                    Console.WriteLine("Senha Válida");
                    return true;
                }else{
                    Console.WriteLine("Senha Inválida, tente novamente");
                    return false;                
                }
            }
        }
    }
}
