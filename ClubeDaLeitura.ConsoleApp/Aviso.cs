using System;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Aviso
    {
        public void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }

    }
}
