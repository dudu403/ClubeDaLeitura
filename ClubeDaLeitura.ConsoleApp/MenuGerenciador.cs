using System;

namespace ClubeDaLeitura.ConsoleApp
{
    public class MenuGerenciador
    {
        public char opcaoMenuPrincipal;
        public char opcaoSubMenu;

        public Caixa[] caixas;
        public int contadorCaixas = 0;
        public Emprestimo[] emprestimos = new Emprestimo[1000];
        public int contadorEmprestimos = 0;
        public Revista[] revistas = new Revista[1000];
        public int contadorRevistas = 0;
        public Amigo[] amigos = new Amigo[1000];
        public int contadorAmigos = 0;

        Aviso aviso = new Aviso();


    
        public void MenuPrincipal()
        {
            Console.WriteLine("--------- Clube da Leitura ---------");
            Console.WriteLine("--------------- Menu ---------------");
            Console.WriteLine("1 - Registros de amigos");
            Console.WriteLine("2 - Registros de empréstimos");
            Console.WriteLine("3 - Registros de caixas");
            Console.WriteLine("4 - Registros de revistas");
            Console.WriteLine("s - Para sair");
            Console.WriteLine("------------------------------------");
            Console.Write("Digite sua opção: ");
            opcaoMenuPrincipal = Convert.ToChar(Console.ReadLine());
            Console.Clear();
        }
        
        
        public void VerificaOpcaoMenuPrincipal()
        {
           
            switch (opcaoMenuPrincipal)
            {
                case '1':
                    while (true)
                    {
                        MenuRegistrosDeAmigos();
                        ObterOpcaoSubMenu();
                        if(opcaoSubMenu == 's')
                        {
                            break;
                        }
                        VerificarOpcaoSubMenu();
                        Console.Clear();
                    }
                    
                    break;
                case '2':
                    while (true)
                    {
                        MenuRegistrosDeEmprestimos();
                        ObterOpcaoSubMenu();
                        if (opcaoSubMenu == 's')
                        {
                            break;
                        }
                        
                        VerificarOpcaoSubMenu();
                        Console.Clear();
                    }

                    break;
                case '3':
                    while (true)
                    {
                        MenuRegistrosDeCaixas();
                        ObterOpcaoSubMenu();
                        if (opcaoSubMenu == 's')
                        {
                            break;
                        }
                        VerificarOpcaoSubMenu();
                        Console.Clear();
                    }

                    break;
                case '4':
                    while (true)
                    {
                        MenuRegistrosDeRevistas();
                        ObterOpcaoSubMenu();
                        if (opcaoSubMenu == 's')
                        {
                            break;
                        }
                        VerificarOpcaoSubMenu();
                        Console.Clear();
                    }
                    break;
                default:
                    aviso.ApresentarMensagem("Opção Inválida. Tente novamente.", ConsoleColor.Red);
                    break;
            }
        }


        #region SubMenus
        public void MenuRegistrosDeAmigos()
        {
            Console.WriteLine("--------- Clube da Leitura ---------");
            Console.WriteLine("--------------- Menu ---------------");
            Console.WriteLine("1 - Registrar novo amigo");
            Console.WriteLine("2 - Visualizar amigos");
            Console.WriteLine("3 - Editar registro de amigos");
            Console.WriteLine("s - Para voltar");
            Console.WriteLine("------------------------------------");
        }
        public void MenuRegistrosDeCaixas()
        {
            Console.WriteLine("--------- Clube da Leitura ---------");
            Console.WriteLine("--------------- Menu ---------------");
            Console.WriteLine("1 - Registrar nova caixa");
            Console.WriteLine("2 - Visualizar caixas");
            Console.WriteLine("3 - Editar registro de caixas");
            Console.WriteLine("s - Para voltar");
            Console.WriteLine("------------------------------------");
        }
        public void MenuRegistrosDeRevistas()
        {
            Console.WriteLine("--------- Clube da Leitura ---------");
            Console.WriteLine("--------------- Menu ---------------");
            Console.WriteLine("1 - Registrar nova revista");
            Console.WriteLine("2 - Visualizar revistas");
            Console.WriteLine("3 - Editar registro de revistas");
            Console.WriteLine("4 - Remover revista");
            Console.WriteLine("s - Para voltar");
            Console.WriteLine("------------------------------------");
        }
        public void MenuRegistrosDeEmprestimos()
        {
            Console.WriteLine("--------- Clube da Leitura ---------");
            Console.WriteLine("--------------- Menu ---------------");
            Console.WriteLine("1 - Registrar novo empréstimo");
            Console.WriteLine("2 - Registrar devolução");
            Console.WriteLine("3 - Visualizar empréstimos");
            Console.WriteLine("s - Para voltar");
            Console.WriteLine("------------------------------------");
            

        }
        public void VerificarOpcaoSubMenu()
        {
            switch (opcaoMenuPrincipal)
            {
                case '1':

                    switch (opcaoSubMenu)
                    {
                        case '1':
                            RegistrarNovoAmigo();
                            break;
                        case '2':
                            VisualizarAmigos();
                            break;
                        case '3':
                            EditarAmigo();
                            break;
                        case 's':
                            break;

                    }
                    break;
                case '2':

                    switch (opcaoSubMenu)
                    {
                        case '1':
                            RegistrarEmprestimo();
                            break;
                        case '2': 
                            RegistrarDevolucao();
                            break;
                        case '3':
                            VisualizarEmprestimos();
                            break;
                        case 's':
                            break;
                    }
                    break;
                case '3':
                    switch (opcaoSubMenu)
                    {
                        case '1': 
                            RegistrarCaixa();
                            break;
                        case '2':
                            VisualizarCaixas();
                            break;
                        case '3': 
                            EditarCaixas();
                            break;
                        case 's':
                            break;
                    }
                    break;
                case '4':
                    switch (opcaoSubMenu)
                    {
                        case '1': 

                            RegistrarRevista();
                            break;
                        case '2': 
                            VisualizarRevistas();
                            break;
                        case '3': 
                            EditarRevistas();
                            break;
                        case '4':
                            //RemoverRevista();
                            break;
                        case 's':
                            break;
                    }
                    break;
            }
        }

        public void ObterOpcaoSubMenu()
        {

            Console.Write("Digite sua opção: ");
            opcaoSubMenu = Convert.ToChar(Console.ReadLine());


        }
        #endregion

        #region Registro de revistas
        public void RegistrarRevista()
        {
            Console.Clear();
            Revista novaRevista = new Revista();
            novaRevista.caixas = caixas;
            novaRevista.contadorCaixas = contadorCaixas;
            novaRevista.CadastrarRevista();

            revistas[contadorRevistas] = novaRevista;
            contadorRevistas++;
        }
        public void EditarRevistas()
        {
            Console.Clear();
            VisualizarRevistas();
            while (true)
            {
                if(contadorRevistas == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite o Id da revista que deseja editar: ");
                    int idRevista = Convert.ToInt32(Console.ReadLine());
                    revistas[idRevista].EditarRevista();
                }
            }
        
        }
        public void VisualizarRevistas()
        {
            VisualizaRegistro VisualizarRecistas = new VisualizaRegistro();
            VisualizarRecistas.revistas = revistas;
            VisualizarRecistas.contadorRevistas = contadorRevistas;
            VisualizarRecistas.VisualizarRevistas();
        }
        
        #endregion

        #region Registro de Caixas
        public void VisualizarCaixas()
        {
            VisualizaRegistro visualixarCaixas = new VisualizaRegistro();
            visualixarCaixas.caixas = caixas;
            visualixarCaixas.contadorCaixas = contadorCaixas;
            visualixarCaixas.VisualizarRegistroCaixas();
        }
        public void RegistrarCaixa()
        {
            Console.Clear();
            Caixa novaCaixa = new Caixa();
            novaCaixa.RegistrarCaixa();
            caixas[contadorCaixas] = novaCaixa;
            contadorCaixas++;
        }
        public void EditarCaixas()
        {
            Console.Clear();
            VisualizarCaixas();
            Console.WriteLine("Digite o Id da que deseja editar: ");
            int idCaixa = Convert.ToInt32(Console.ReadLine());
            caixas[idCaixa].EditarRegistro();
        }
        #endregion

        #region Registro de Emprestimos
        public void RegistrarEmprestimo()
        {
           Console.Clear();
            if(contadorAmigos == 0)
            {
                aviso.ApresentarMensagem("Não há nenhum amigo registrado!", ConsoleColor.Yellow);
            }
            else if(contadorRevistas == 0)  
            {
                aviso.ApresentarMensagem("Não há nenhuma revista cadastrada! ", ConsoleColor.Yellow);
            }
            else
            {
                Emprestimo novoEmprestimo = new Emprestimo();
                novoEmprestimo.amigos = amigos;
                novoEmprestimo.contadorAmigos = contadorAmigos;
                novoEmprestimo.revistas = revistas;
                novoEmprestimo.contadorRevistas = contadorRevistas;

                novoEmprestimo.FazerEmprestimo();
                emprestimos[contadorEmprestimos] = novoEmprestimo;
                contadorEmprestimos++;

            }
           
        }
        public void RegistrarDevolucao()
        {
            Console.Clear();
            if (contadorEmprestimos == 0)
            {
                aviso.ApresentarMensagem("Não há nenhum empréstimo registrado!", ConsoleColor.Yellow);
            }
            else
            {
                VisualizarEmprestimos();
                while (true) { 
                Console.Write("Digite o id do emprestimo que deseja registrar devolução: ");
                    int IdDevolucao = Convert.ToInt32(Console.ReadLine());
                    if (IdDevolucao > contadorEmprestimos || IdDevolucao < 0)
                    {
                        aviso.ApresentarMensagem("Id não encontrado. Tente novamente", ConsoleColor.Red);
                        continue;
                    }
                    emprestimos[IdDevolucao].amigoEmprestimo = emprestimos[IdDevolucao].amigos[IdDevolucao];
                    emprestimos[IdDevolucao].FazerDevolucao();
                    break;
                }
            }
        }
        public void VisualizarEmprestimos()
        {
            VisualizaRegistro visualizarEmprestomos = new VisualizaRegistro();
            visualizarEmprestomos.emprestimos = emprestimos;
            visualizarEmprestomos.contadorEmprestimos = contadorEmprestimos;
            visualizarEmprestomos.VisualizarEmprestimos();
            
        }
        #endregion

        public void RegistrarNovoAmigo()
        {
            Console.Clear();
            Amigo novoAmigo = new Amigo();
            novoAmigo.RegistrarAmigo();
            amigos[contadorAmigos] = novoAmigo;
            contadorAmigos++;
        }
        public void VisualizarAmigos()
        {
            VisualizaRegistro visualizarAmigos = new VisualizaRegistro();
            visualizarAmigos.amigos = amigos;
            visualizarAmigos.contadorAmigos = contadorAmigos;
            visualizarAmigos.VisualizarAmigos();

        }
        public void EditarAmigo()
        {
            Console.Clear();
            VisualizarAmigos();
            while (true)
            {
                if (contadorAmigos == 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Digite o Id do amigo que deseja editar: ");
                    int idAmigo = Convert.ToInt32(Console.ReadLine());
                    amigos[idAmigo].EditarRegistro();
                    break;
                }
            }

        }

        //public void removerRevista(int idRevista)
        //{
        //    Console.WriteLine("--------- Remover Revista ---------");

        //    if (contadorRevistas == 0)
        //    {
        //        aviso.ApresentarMensagem("Não há revistas cadastradas.", ConsoleColor.Yellow);
        //        return;
        //    }

        //    VisualizarRevistas();

        //    Console.Write("Digite o número da revista que deseja remover: ");
        //    idRevista = Convert.ToInt32(Console.ReadLine());

        //    bool revistaEncontrada = false;
        //    for (int i = 0; i < contadorRevistas; i++)
        //    {
        //        if (revistas[i] != null && revistas[i].numeroEdicao == idRevista)
        //        {
        //            revistas[i] = null;
        //            Console.WriteLine("Revista removida com sucesso!");
        //            return;
        //        }
        //    }
        //    Console.WriteLine("Revista não encontrada!");
        //}


    }
}
