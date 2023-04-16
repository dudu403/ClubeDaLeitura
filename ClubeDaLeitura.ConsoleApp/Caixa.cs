using System;

namespace ClubeDaLeitura.ConsoleApp
{

    public class Caixa
    {
        public string cor;
        public string etiqueta;
        public int numero;
        public Revista [] revistas;
        public int contadorRevistasDaCaixa = 0;
        Aviso aviso = new Aviso();

        public void RegistrarCaixa()
        {
            Console.Write("Cor da caixa: ");
            cor = Console.ReadLine();
            Console.Write("Etiqueta da caixa: ");
            etiqueta = Console.ReadLine();
            Console.Write("Número da caixa: ");
            numero = Convert.ToInt32(Console.ReadLine());
            contadorRevistasDaCaixa++;
            aviso.ApresentarMensagem("Caixa cadastrada com sucesso!", ConsoleColor.Green);
        }
        public void EditarRegistro()
        {
            Console.Write("Cor da caixa: ");
            cor = Console.ReadLine();
            Console.Write("Etiqueta da caixa: ");
            etiqueta = Console.ReadLine();
            Console.Write("Número da caixa: ");
            numero = Convert.ToInt32(Console.ReadLine());
            aviso.ApresentarMensagem("Registro editado com sucesso!", ConsoleColor.Green);
        }
    }
}
