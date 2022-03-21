using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Emprestimo
    {
        public string amigoQueEmprestou;
        public string revistaQueEmprestou;
        public DateTime dataQueEmprestou;
        public DateTime dataQueDevolveu;
        public string status;

        public enum StatusDeEmprestimo
        {
            Aberto, Fechado
        }
      
    }
}
