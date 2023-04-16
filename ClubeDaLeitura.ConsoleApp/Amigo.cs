using System;

namespace ClubeDaLeitura.ConsoleApp
{

    public class Amigo
    {
        public string nome;
        public string nomeResponsavel;
        public string telefone;
        public string endereco;
        public bool temEmprestimo = false;

        public void RegistrarAmigo()
        {
            Console.WriteLine(" Cadastro de amigos ");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Nome do responsável: ");
            nomeResponsavel = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.Write("Endereço: ");
            endereco = Console.ReadLine();

            Aviso aviso = new Aviso();
            aviso.ApresentarMensagem("Amigo cadastrado com sucesso!", ConsoleColor.Green);
        }
        public void EditarRegistro()
        {
            Console.WriteLine(" Editar cadastro de amigos ");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Nome do responsável: ");
            nomeResponsavel = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.Write("Digite o endereço ");
            endereco = Console.ReadLine();

            Aviso aviso = new Aviso();
            aviso.ApresentarMensagem("Cadastro editado com sucesso!", ConsoleColor.Green);
        }
        
    }
}
