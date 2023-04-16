using System;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Revista
    {
        public string tipo;
        public string colecao;
        public int numeroEdicao;
        public string dataRevista;
        public bool disponivel = true;
        public string etiqueta;
        public Caixa caixa;

        public Caixa[] caixas;
        public int contadorCaixas;

        Aviso aviso = new Aviso();

        public void CadastrarRevista()
        {
            Console.Clear();
            Console.WriteLine(" Cadastrar Revista ");

            MenuGerenciador menuGerenciador = new MenuGerenciador();
            menuGerenciador.caixas = caixas;
            menuGerenciador.contadorCaixas = contadorCaixas;
            menuGerenciador.VisualizarCaixas();

            if(contadorCaixas == 0)
            {
                aviso.ApresentarMensagem("Registre uma caixa!", ConsoleColor.Yellow);
                menuGerenciador.RegistrarCaixa();
                Console.Clear();
                caixas = menuGerenciador.caixas;
                contadorCaixas = menuGerenciador.contadorCaixas;
                menuGerenciador.VisualizarCaixas();
            }
            while (true)
            {
                Console.Write("Digite a etiqueta da caixa que a revista será guardada: ");
                etiqueta = Console.ReadLine();
                if (EtiquetaExiste() == false)
                {
                    aviso.ApresentarMensagem("Etiqueta não encontrada. Tente novamente.", ConsoleColor.Red);
                    continue;
                }
                break;
            }
                        
            Console.Write("Digite a coleção da revista: ");
            colecao = Console.ReadLine();

            Console.Write("Digite o tipo (gênero) da revista: ");
            tipo = Console.ReadLine();

            Console.Write("Digite o número da edição: ");
            numeroEdicao = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    Console.Write("Digite a data da revista: ");
                    dataRevista = DateTime.Parse(Console.ReadLine()).ToString("dd/MM/yyyy");
                }
                catch (Exception)
                {
                    aviso.ApresentarMensagem("ERRO! A data de abertura deve ser válida! Tente novamente.", ConsoleColor.Red);
                    continue;
                }
                break;
            }
        }

        public void EditarRevista()
        {
            Console.Clear();
            Console.WriteLine(" Editar cadastro de revista ");

            MenuGerenciador menuGerenciador = new MenuGerenciador();
            menuGerenciador.caixas = caixas;
            menuGerenciador.contadorCaixas = contadorCaixas;
            
            while (true)
            {
                menuGerenciador.VisualizarCaixas();
                Console.Write("Digite a etiqueta da caixa que a revista será guardada: ");
                etiqueta = Console.ReadLine();
                if (EtiquetaExiste() == false)
                {
                    aviso.ApresentarMensagem("Etiqueta não encontrada. Tente novamente.", ConsoleColor.Red);
                    continue;
                }
                else
                {
                    Console.Write("Digite a coleção da revista: ");
                    colecao = Console.ReadLine();

                    Console.Write("Digite o tipo/gênero da revista: ");
                    tipo = Console.ReadLine();

                    Console.Write("Digite o número da edição: ");
                    numeroEdicao = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {
                        try
                        {
                            Console.Write("Digite a data da revista: ");
                            dataRevista = DateTime.Parse(Console.ReadLine()).ToString("dd/MM/yyyy");
                        }
                        catch (Exception)
                        {
                            aviso.ApresentarMensagem("ERRO! A data de abertura deve ser válida! Tente novamente.", ConsoleColor.Red);
                            continue;
                        }
                        break;
                    }
                }
                break;
            }

          
        }
        private bool EtiquetaExiste()
        {
            bool etiquetaExistente = false;
            
            for (int i = 0; i < contadorCaixas; i++)
            {
                if(etiqueta == caixas[i].etiqueta)
                {
                    etiquetaExistente = true;
                }
            }
            return etiquetaExistente;     
        }
       
    }
}
