using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoNotas
{
    class Nota
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }

        static List<Nota> notas = new List<Nota>();

        public Nota(string titulo, string conteudo)
        {
            Titulo = titulo;
            Conteudo = conteudo;
        }

        public static void AdicionarNota()
        {
            Console.WriteLine("Digite o título da nota: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o conteúdo da nota: ");
            string conteudo = Console.ReadLine();

            Nota nota = new Nota(titulo, conteudo);
            notas.Add(nota);

            Console.WriteLine("Nota adicionada com sucesso.");
        }

        public static void VisualizarNotas()
        {
            foreach (Nota nota in notas)
            {
                Console.WriteLine("Título: " + nota.Titulo);
                Console.WriteLine("Conteúdo: " + nota.Conteudo);
                Console.WriteLine("----------------------");
            }
        }

        
        public static void EditarNota()
        {
            Console.WriteLine("Digite o título da nota que deseja editar: ");
            string titulo = Console.ReadLine();

            Nota nota = notas.Find(n => n.Titulo == titulo);

            if (nota != null)
            {
                Console.WriteLine("Digite o novo título da nota: ");
                string novoTitulo = Console.ReadLine();

                Console.WriteLine("Digite o novo conteúdo da nota: ");
                string novoConteudo = Console.ReadLine();

                nota.Titulo = novoTitulo;
                nota.Conteudo = novoConteudo;

                Console.WriteLine("Nota editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Nota não encontrada.");
            }
        }

        public static void ExcluirNota()
        {
            Console.WriteLine("Digite o título da nota que deseja excluir: ");
            string titulo = Console.ReadLine();

            Nota nota = notas.Find(n => n.Titulo == titulo);

            if (nota != null)
            {
                notas.Remove(nota);
                Console.WriteLine("Nota excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Nota não encontrada.");
            }
        }
    }

}


