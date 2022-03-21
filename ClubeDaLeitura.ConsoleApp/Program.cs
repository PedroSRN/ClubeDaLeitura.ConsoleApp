using System;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MenuPrincipal menu = new MenuPrincipal();

            while (true)
            {
                menu.ApresentarMenu();
                menu.ValidarOpcaoMenu();
            }
        }
    }
}
