using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    
    public class VisualizaRegistro
    {
        public Amigo[] amigos;
        public int contadorAmigos = 0;
        public Caixa[] caixas;
        public int contadorCaixas = 0;
        public Emprestimo[] emprestimos;
        public int contadorEmprestimos = 0;
        public Revista[] revistas;
        public int contadorRevistas = 0;

        Aviso aviso = new Aviso();
        
        public void VisualizarRegistroCaixas()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0, -10} | {1, -30} | {2, -30} | {3, -30}", "Id","Etiqueta", "Numero", "Cor");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            if (contadorCaixas == 0)
            {
                aviso.ApresentarMensagem("Não há nenhuma caixa registrada!", ConsoleColor.Yellow);
            }
            else
            {
                for (int i = 0; i < contadorCaixas; i++)
                {
                    Console.WriteLine("{0, -10} | {1, -30} | {2, -30} | {3, -30} ", i, caixas[i].etiqueta, caixas[i].numero, caixas[i].cor);
                }
            }
            Console.ReadKey();
        }
        public void VisualizarAmigos()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0, -5} | {1, -20} | {2, -20} | {3, -20} | {4, -40}", "Id", "Amigo", "Responsável", "Telefone", "Endereço");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            if (contadorAmigos == 0)
            {
                aviso.ApresentarMensagem("Não há nenhum amigo cadastrado!", ConsoleColor.Yellow);
            }
            else
            {
                for (int i = 0; i < contadorAmigos; i++)
                {
                    Console.WriteLine("{0, -5} | {1, -20} | {2, -20} | {3, -20} | {4, -40}", i, amigos[i].nome, amigos[i].nomeResponsavel, amigos[i].telefone, amigos[i].endereco);
                }
            }
            Console.ReadKey();
        }
        public void VisualizarRevistas()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0, -5} | {1, -25} | {2, -25} | {3, -25} | {4, -25}", "Id", "Coleção", "Tipo", "Nº da Edição", "Data da Revisata");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            if (contadorRevistas == 0)
            {
                aviso.ApresentarMensagem("Não há nenhuma revista registrada.", ConsoleColor.Yellow);
            }
            else
            {
                for (int i = 0; i < contadorRevistas; i++)
                {
                    Console.WriteLine("{0, -5} | {1, -25} | {2, -25} | {3, -25} | {4, -25}", i, revistas[i].colecao, revistas[i].tipo, revistas[i].numeroEdicao, revistas[i].dataRevista);
                }
            }
            Console.ReadKey();
        }
        public void VisualizarEmprestimos()
        {
            
            Console.WriteLine("{0, -5} | {1, -25} | {2, -25} | {3, -25} | {4, -25}", "Id", "Nome do Amigo", "Revista - Edição", "Data de Empréstimo", "Data da Devolução");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            if(contadorEmprestimos == 0)
            {
                aviso.ApresentarMensagem("Não há nenhum imprestimo registrado.", ConsoleColor.Yellow);
            }
            for (int i = 0; i < contadorEmprestimos; i++)
            {
                Console.WriteLine("{0, -5} | {1, -25} | {2, -25} | {3, -25} | {4, -25}", i, emprestimos[i].amigoEmprestimo.nome, emprestimos[i].revistaEmprestada.colecao + " - "+ emprestimos[i].revistaEmprestada.numeroEdicao, emprestimos[i].dataEmprestimo, emprestimos[i].dataDevolucao);
            }
            Console.ReadKey();
            
        }

    }
}
