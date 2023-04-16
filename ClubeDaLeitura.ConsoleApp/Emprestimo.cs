using System;

namespace ClubeDaLeitura.ConsoleApp
{
   
    public class Emprestimo
    {
        public Revista[] revistas;
        public int contadorRevistas = 0;
        public Amigo[] amigos;
        public int contadorAmigos = 0;
        Aviso aviso = new Aviso();
        
       
        public Amigo amigoEmprestimo;
        public Revista revistaEmprestada;
        public string dataEmprestimo;
        public string dataDevolucao = "--";


        public void FazerEmprestimo()
        {
            Console.Clear();
            Console.WriteLine(" Registro de empréstimo ");
            LocalizarAmigo();
            
            ObterRevista();

            ObterDataEmprestimo();

        }
        public void FazerDevolucao()
        {
            Console.WriteLine(" Registro de devolução ");
            while (true)
            {
                try
                {
                    Console.Write("Data de devolução: "); ;
                    dataDevolucao = DateTime.Parse(Console.ReadLine()).ToString("dd/MM/yyyy");
                }
                catch (Exception)
                {
                    aviso.ApresentarMensagem("ERRO! A data de abertura deve ser válida! Tente novamente.", ConsoleColor.Red);
                    continue;
                }
                break;
            }
            amigoEmprestimo.temEmprestimo = false;
            revistaEmprestada.disponivel = true;
           

        }

        public void ObterDataEmprestimo()
        {
            while (true)
            {
                try
                {
                    Console.Write("Data de empréstimo: "); ;
                    dataEmprestimo = DateTime.Parse(Console.ReadLine()).ToString("dd/MM/yyyy");
                }
                catch (Exception)
                {
                    aviso.ApresentarMensagem("ERRO! A data de abertura deve ser válida! Tente novamente.", ConsoleColor.Red);
                    continue;
                }
                break;
            }
        }
        private void ObterRevista()
        {
            while (true)
            {
                MenuGerenciador menuGerenciador = new MenuGerenciador();
                menuGerenciador.revistas = revistas;
                menuGerenciador.contadorRevistas = contadorRevistas;
                menuGerenciador.VisualizarRevistas();
          
                Console.Write("Id da revista: ");
                int idRevista = Convert.ToInt32(Console.ReadLine());
                bool revistaRegistrada = false; 
                for (int i = 0; i < contadorRevistas; i++)
                {
                    if (idRevista == i)
                    {
                        revistaEmprestada = revistas[i];
                        revistaEmprestada.disponivel = false;
                        revistaRegistrada = true;

                    }
                }
                if (revistaRegistrada == false)
                {
                    aviso.ApresentarMensagem("Revista não encontrada!", ConsoleColor.Red);
                    continue;
                }
                break;
            }
        }
        private void LocalizarAmigo()
        {
            while (true)
            {
                MenuGerenciador menuGerenciador = new MenuGerenciador();
                menuGerenciador.amigos = amigos;
                menuGerenciador.contadorAmigos = contadorAmigos;
                menuGerenciador.VisualizarAmigos();
                
                Console.Write("Digite o id do amigo: ");
                int IdAmigo = Convert.ToInt32( Console.ReadLine());
                bool amigoEhCadastrado = false;
                for (int i = 0; i < contadorAmigos; i++)
                {
                    if (IdAmigo == i)
                    {
                        if (amigos[i].temEmprestimo == false)
                        {
                            amigoEmprestimo = amigos[i];
                            amigoEmprestimo.temEmprestimo = true;
                            amigoEhCadastrado = true;
                            break;
                        }
                        else
                        {
                            aviso.ApresentarMensagem("Esse amigo tem uma revista não devolvida. Para fazer outro empréstimo é necessario fazer a devolução.", ConsoleColor.Red);
                            continue;
                        }

                    }
                    if (amigoEhCadastrado == false)
                    {
                        aviso.ApresentarMensagem("Amigo não encontrado! ", ConsoleColor.Red);
                        continue;
                    }
                }
                break;
            }
        }
        
    }
}
