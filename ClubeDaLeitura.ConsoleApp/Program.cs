using System;
namespace ClubeDaLeitura.ConsoleApp
{
    public class Program
    {
        public static Caixa[] caixas = new Caixa[1000];
        public static int contadorCaixas = 0;
        public static Emprestimo[] emprestimos = new Emprestimo[1000];
        public static int contadorEmprestimos = 0;
        public static Revista[] revistas = new Revista[1000];
        public static int contadorRevistas = 0;
        public static Amigo[] amigos = new Amigo[1000];
        public static int contadorAmigos = 0;


        public static void Main(string[] args)
        {
            
            MenuGerenciador inicio = new MenuGerenciador();
            inicio.caixas = caixas;
            inicio.emprestimos = emprestimos;
            inicio.revistas = revistas;
            inicio.amigos = amigos;
            inicio.contadorCaixas = contadorCaixas;
            inicio.contadorEmprestimos = contadorEmprestimos;
            inicio.contadorRevistas = contadorRevistas;
            inicio.contadorAmigos = contadorAmigos ;

            while (true)
            {
                inicio.MenuPrincipal();
                
                if (inicio.opcaoMenuPrincipal == 's')
                {
                    break;
                }
                else
                {

                    inicio.VerificaOpcaoMenuPrincipal();
                    
                    Console.Clear();
                }
            }
        }
    }
}
