using System;
using System.Collections.Generic;
using static BlocoNotas.Nota;

namespace BlocoNotas
{
    class Program
    {

        static void Main(string[] args)
        {
            bool executando = true;
            int opcao;

            while (executando)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar nota");
                Console.WriteLine("2 - Visualizar notas");
                Console.WriteLine("3 - Editar nota");
                Console.WriteLine("4 - Excluir nota");
                Console.WriteLine("5 - Sair");

                string escolha = Console.ReadLine();

                while(int.TryParse(escolha, out opcao))
                {
                    Console.WriteLine("Opção inválida! Tente novamente!");
                    escolha = Console.ReadLine();
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarNota();
                        break;
                    case 2:
                        VisualizarNotas();
                        break;
                    case 3:
                        EditarNota();
                        break;
                    case 4:
                        ExcluirNota();
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
