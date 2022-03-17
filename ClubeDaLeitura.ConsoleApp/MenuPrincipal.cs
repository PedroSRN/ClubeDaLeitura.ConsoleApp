using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class MenuPrincipal
    {
        Revista[] revista = new Revista[100];
        Caixa[] caixa = new Caixa[100];
        Amigo[] amigo = new Amigo[100];
        Emprestimo[] emprestimo = new Emprestimo[100];
        public string opcao;

        public void ApresentarMenu()
        {
            Console.WriteLine("        *--CLUBE DO LIVRO--*");
            Console.WriteLine("         *------Menu------*");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Digite 1 para Registrar uma Revista");
            Console.WriteLine("Digite 2 para Visualizar uma Revista");
            Console.WriteLine("Digite 3 para Registrar uma Caixa");
            Console.WriteLine("Digite 4 para Visualizar uma Caixa");
            Console.WriteLine("Digite 5 para Registrar um Amigo");
            Console.WriteLine("Digite 6 para Visualizar um Amigo");
            Console.WriteLine("Digite 7 para Registrar um Empréstimo");
            Console.WriteLine("Digite 8 para Visualizar um Empréstimo");
            Console.WriteLine("Digite 0 SAIR");
            Console.WriteLine("--------------------------------------");
            opcao = Console.ReadLine();
        }

        public void ValidarOpcaoMenu()
        {
            if (opcao == "1")
            {
                CadastrarRevista();

            }
            if (opcao == "2")
            {
                VisualizarRevista();

            }
            if (opcao == "3")
            {
                CadastrarCaixa();

            }
            if (opcao == "4")
            {
                VisualizarCaixa();
            }
            if (opcao == "5")
            {
                CadastrarAmigo();
            }
            if (opcao == "6")
            {
                VisualizarAmigo();
            }
            if (opcao == "7")
            {
                EmprestimoDeLivros();
            }
            if (opcao == "8")
            {
                VisualizarEmprestimos();
            }
            if (opcao == "0")
            {
                Environment.Exit(0);//sair
            }


        }

       #region  REVISTA
        public void CadastrarRevista()
        {
            Revista novaRevista = new Revista();
            int id;

                Console.Clear();
                Console.WriteLine("CADASTRO DE REVISTAS-----");
                Console.WriteLine();
                Console.Write("Digite o Tipo da Revista: ");
                string tipo = Console.ReadLine();

                Console.Write("Digite o Número da Edição: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o Ano da Revista: ");
                int ano = Convert.ToInt32(Console.ReadLine());
    
               
            novaRevista.tipoDaRevista = tipo;
            novaRevista.numeroEdicao = numero;
            novaRevista.anoRevista = ano;

            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                {
                    revista[i] = novaRevista;
                }
            }

            
        }
        public void VisualizarRevista()
        {
            Console.Clear();
            
            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                {
                    Console.WriteLine("Nenhuma Revista foi cadastrada");
                    break;
                }
                else
                {
                    Console.WriteLine("Tipo da Revista : " + revista[i].tipoDaRevista);
                    Console.WriteLine("Número da Edição: " + revista[i].numeroEdicao);
                    Console.WriteLine("Ano da Revista  : " + revista[i].anoRevista);
                    Console.WriteLine();
                    break;
                }
            }
            Console.ReadLine();
            Console.Clear();

        }
        #endregion

        #region CAIXA
        public void CadastrarCaixa()
        {
            Caixa novaCaixa = new Caixa();
            
            Console.Clear();
            Console.WriteLine("CADASTRO DE CAIXAS-----");
            Console.Write("Digite a Cor da Caixa: ");
            string corDacaixa = Console.ReadLine();

            Console.Write("Digite a Etiqueta da Caixa: ");
            string etiquetaDacaixa = Console.ReadLine();

            Console.Write("Digite o Número da Caixa: ");
            int numeroDacaixa = Convert.ToInt32(Console.ReadLine());

            novaCaixa.cor = corDacaixa;
            novaCaixa.etiqueta = etiquetaDacaixa;
            novaCaixa.numero = numeroDacaixa;

            for (int i = 0; i < caixa.Length; i++)
            {

                if (caixa[i] == null)
                {
                    caixa[i] = novaCaixa;
                }

            }

        }


        public void VisualizarCaixa()
        {
            Console.Clear();
            for (int i = 0; i < caixa.Length; i++)
            {
                if (caixa[i] == null)
                {
                    Console.WriteLine("Nenhuma Caixa foi cadastrada");
                    break;
                }
                else
                {
                    Console.WriteLine("Cor da Caixa     : " + caixa[i].cor);
                    Console.WriteLine("Etiqueta da Caixa: " + caixa[i].etiqueta);
                    Console.WriteLine("Número da Caixa  : " + caixa[i].numero);
                    Console.WriteLine();
                    break;
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

        #region AMIGO
        public void CadastrarAmigo()
        {
            Amigo novoAmigo = new Amigo();
            
            Console.Clear();
            Console.WriteLine("CADASTRO DE AMIGOS-----");
            Console.Write("Digite o Nome do Amigo: ");
            string nome = Console.ReadLine();
            
            Console.Write("Digite o Endereço do Amigo: ");
            string enderecoAmigo = Console.ReadLine();
           
            Console.Write("Digite o Nome do Responsavel do Amigo: ");
            string responsavelAmigo = Console.ReadLine();
            
            Console.Write("Digite o Telefone do Amigo: ");
            int telefoneAmigo = Convert.ToInt32(Console.ReadLine());

            novoAmigo.nomeAmigo = nome;
            novoAmigo.endereco = enderecoAmigo;
            novoAmigo.responsavel = responsavelAmigo;
            novoAmigo.telefone = telefoneAmigo;

            for (int i = 0; i < amigo.Length; i++)
            {
                if(amigo[i] == null)
                {
                    amigo[i] = novoAmigo;
                }
            }

        }

        public void VisualizarAmigo()
        {
            Console.Clear();
            for (int i = 0; i < amigo.Length; i++)
            {
                if (amigo[i] == null)
                {
                    Console.WriteLine("Nenhum Amigo foi cadastrado");
                    break;
                }
                else
                {
                    Console.WriteLine("Nome do Amigo      : " + amigo[i].nomeAmigo);
                    Console.WriteLine("Endereço           : " + amigo[i].endereco);
                    Console.WriteLine("Nome do Responsavel: " + amigo[i].responsavel);
                    Console.WriteLine("Telefone do Amigo  : " + amigo[i].telefone);
                    Console.WriteLine();
                    break;
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

        #region  EMPRESTIMO 
        public void EmprestimoDeLivros()
        {
            Emprestimo novoEmprestimo = new Emprestimo();

            Console.Clear();
            Console.WriteLine("CADASTRO DE EMPRÉSTIMOS-----");
            Console.Write("Digite o Nome do Amigo Que Está Emprestando o Livro: ");
            string amigoEmprestimo = Console.ReadLine();

            Console.Write("Digite o Nome da Revista Emprestada: ");
            string revistaEmprestimo = Console.ReadLine();

            Console.Write("Digite a Data do Emprestimo: ");
            DateTime dataEmprestimo = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a Data de Devolução:");
            DateTime dataDevolução = Convert.ToDateTime(Console.ReadLine());

            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (amigoEmprestimo == amigo[i].nomeAmigo)
                {
                    novoEmprestimo.amigoQueEmprestou = amigoEmprestimo;
                }
                else
                {
                    Console.WriteLine("O Amigo Que Está Tentando o Empéstimo Não Possui Cadastro Ainda");
                    Console.ReadLine();
                    break;
                }

                if (revistaEmprestimo == revista[i].tipoDaRevista)
                {
                    novoEmprestimo.revistaQueEmprestou = revistaEmprestimo;
                }
                else
                {
                    Console.WriteLine("A Revista Que Está Sendo Escolhida Para Empéstimo Ainda não foi Cadastrada");
                    Console.ReadLine();
                    break;
                }
                novoEmprestimo.dataQueEmprestou = dataEmprestimo;
                
                novoEmprestimo.dataQueDevolveu = dataDevolução;
            }
        }

        public void VisualizarEmprestimos()
        {
            Console.Clear();
            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] == null)
                {
                    Console.WriteLine("Nenhum  Emprestimo foi cadastrado");
                    break;
                }
                else
                {
                    Console.WriteLine("Amigo Que Emprestou: " + emprestimo[i].amigoQueEmprestou);
                    Console.WriteLine("Nome da Revista: " + emprestimo[i].revistaQueEmprestou);
                    Console.WriteLine("Data de Empréstimo: " + emprestimo[i].dataQueEmprestou);
                    Console.WriteLine("Data de Devolução: " + emprestimo[i].dataQueDevolveu);
                    Console.WriteLine();
                    break;
                }
            }
            Console.ReadLine();
            Console.Clear();
        }

        #endregion
    }
}
