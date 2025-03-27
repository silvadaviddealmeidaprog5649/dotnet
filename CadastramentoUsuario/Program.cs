using System;
using System.Collections.Generic;
using static CadastramentoUsuario.Cliente;

namespace CadastroClientes
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool executando = true;
            int escolha;

            while (executando)
            {
                Console.WriteLine("Bem Vindo ao sistema de cadastramento:");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar cliente");
                Console.WriteLine("2 - Visualizar clientes");
                Console.WriteLine("3 - Editar cliente");
                Console.WriteLine("4 - Excluir cliente");
                Console.WriteLine("5 - Sair");

                string opcao = Console.ReadLine();

                while(!(int.TryParse(opcao, out escolha)))
                {
                    Console.WriteLine("Opção inválida! Digite novamente!");
                    opcao = Console.ReadLine();
                }
                

                switch (escolha)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        VisualizarClientes();
                        break;
                    case 3:
                        EditarCliente();
                        break;
                    case 4:
                        ExcluirCliente();
                        break;
                    case 5:
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
