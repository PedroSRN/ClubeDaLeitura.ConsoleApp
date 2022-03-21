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
        Reserva[] reserva = new Reserva[100];
        Categoria[] categoria = new Categoria[100];
        public string opcao;

        public void ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("        *--CLUBE DO LIVRO--*");
            Console.WriteLine("         *------Menu------*");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Digite 1 para Registrar uma Caixa");
            Console.WriteLine("Digite 2 para Visualizar uma Caixa");
            Console.WriteLine("Digite 3 para Registrar uma Revista");
            Console.WriteLine("Digite 4 para Registrar Categoria a uma Revista");
            Console.WriteLine("Digite 5 para Visualizar uma Revista");
            Console.WriteLine("Digite 6 para Registrar um Amigo");
            Console.WriteLine("Digite 7 para Visualizar um Amigo");
            Console.WriteLine("Digite 8 para Registrar um Empréstimo");
            Console.WriteLine("Digite 9 para Visualizar um Empréstimo");
            Console.WriteLine("Digite 10 para Visualizar Empréstimos Mensal");
            Console.WriteLine("Digite 11 para Registrar uma Reserva");
            Console.WriteLine("Digite 0 SAIR");
            Console.WriteLine("--------------------------------------");
            opcao = Console.ReadLine();
        }

        public void ValidarOpcaoMenu()
        {
            if (opcao == "1")
            {
                CadastrarCaixa();
            }
            if (opcao == "2")
            {
                VisualizarCaixa();
                
            }
            if (opcao == "3")
            { 
                CadastrarRevista();
            }
            if (opcao == "4")
            {
                CategoriaRevista();
            }
            if (opcao == "5")
            {
                VisualizarRevista();
               
            }
            if (opcao == "6")
            {
                CadastrarAmigo();
            }
            if (opcao == "7")
            {
                VisualizarAmigo();
                
            }
            if (opcao == "8")
            {
                EmprestimoDeLivros();
            }
            if (opcao == "9")
            {
                VisualizarEmprestimos();
                
            }
            if (opcao == "10")
            {
                VisualizarEmprestimosDoMes();

            }
            if (opcao == "11")
            {
                CadastrarReserva();

            }
            if (opcao == "0")
            {
                Environment.Exit(0);//sair
            }


        }

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
                    break;
                }

            }

        }


        public void VisualizarCaixa()
        {
            Console.Clear();

            int numeroCaixasCadastradas = 0;
            Console.WriteLine("VISUALIZAR CAIXAS-----");
            Console.WriteLine();
            for (int i = 0; i < caixa.Length; i++)
            {

                if(caixa[i] != null)
                {
                    Console.WriteLine("Cor da Caixa     : " + caixa[i].cor);
                    Console.WriteLine("Etiqueta da Caixa: " + caixa[i].etiqueta);
                    Console.WriteLine("Número da Caixa  : " + caixa[i].numero);
                    Console.WriteLine();
                    numeroCaixasCadastradas++;
                }
            }
            
                if (numeroCaixasCadastradas == 0)
                {
                    Console.WriteLine("Nenhuma Caixa foi cadastrada");
                    Console.ReadLine(); 
                }
            else
            {
                Console.ReadLine();
            }
            
           
            //Console.Clear();
        }
        #endregion

        #region  REVISTA
        public void CadastrarRevista()
        {
                VisualizarCaixa(); 
            
            Revista novaRevista = new Revista();
            

            
            Console.WriteLine("CADASTRO DE REVISTAS-----");
            Console.WriteLine();
            Console.Write("Digite o Tipo da Revista: ");
            string tipo = Console.ReadLine();

            Console.Write("Digite o Número da Edição: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Ano da Revista: ");
            int ano = Convert.ToInt32(Console.ReadLine());

           
            string nomeCaixa = "";
            int numeroCaixasCadastradas = 0;
            bool caixaEncontrada = false;
            while (caixaEncontrada == false)
            {
                Console.Write("Digite a Etiqueta da Caixa Onde a Revista Está: ");
                nomeCaixa = Console.ReadLine();
                for (int i = 0; i < caixa.Length; i++)
                {
                    if (caixa[i].etiqueta != nomeCaixa)
                    {
                        break;
                    }  

                    if (nomeCaixa == caixa[i].etiqueta)
                    {
                        caixaEncontrada = true;
                        numeroCaixasCadastradas++;
                        break;
                    }
                }

                if (numeroCaixasCadastradas == 0)
                {
                    Console.WriteLine("A Caixa Que Está Sendo Procurada Não Existe");
                    Console.ReadLine();
                    continue;
                }
            }
            
            

            novaRevista.tipoDaRevista = tipo;
            novaRevista.numeroEdicao = numero;
            novaRevista.anoRevista = ano;
            novaRevista.caixaRevista = nomeCaixa;

            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                {
                    revista[i] = novaRevista;
                    break;
                }
            }
        }
        
        public void VisualizarRevista()
        {
            //Console.Clear();
            int numeroRevistaCadastrada = 0;
            Console.WriteLine("VISUALIZAR REVISTAS-----");
            Console.WriteLine();
            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] != null)
                {
                    Console.WriteLine("Tipo da Revista : " + revista[i].tipoDaRevista);
                    Console.WriteLine("Número da Edição: " + revista[i].numeroEdicao);
                    Console.WriteLine("Ano da Revista  : " + revista[i].anoRevista);
                    Console.WriteLine("Caixa da Revista: " + revista[i].caixaRevista); 
                    Console.WriteLine();
                    numeroRevistaCadastrada++;
                }

            }

            if (numeroRevistaCadastrada == 0)
            {
                Console.WriteLine("Nenhuma Revista foi cadastrada");
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }
           
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
                    break;
                }
            }

        }

        public void VisualizarAmigo()
        {
            //Console.Clear();
            int numeroAmigosCadastrados = 0;
            Console.WriteLine("VISUALIZAR AMIGOS-----");
            Console.WriteLine();
            for (int i = 0; i < amigo.Length; i++)
            {

                if (amigo[i] != null)
                {
                    Console.WriteLine("Nome do Amigo      : " + amigo[i].nomeAmigo);
                    Console.WriteLine("Endereço           : " + amigo[i].endereco);
                    Console.WriteLine("Nome do Responsavel: " + amigo[i].responsavel);
                    Console.WriteLine("Telefone do Amigo  : " + amigo[i].telefone);
                    Console.WriteLine();
                    numeroAmigosCadastrados++;
                }
            }
                if (numeroAmigosCadastrados == 0)
                {
                    Console.WriteLine("Nenhum Amigo foi cadastrado");
                    Console.ReadLine();
                }
                else
                {
                    Console.ReadLine();
                }

            //Console.Clear();
        }
        #endregion

        #region  EMPRESTIMO 
        public void EmprestimoDeLivros()
        {
            VisualizarAmigo();
            VisualizarRevista();

            Emprestimo novoEmprestimo = new Emprestimo();

           
            Console.WriteLine("CADASTRO DE EMPRÉSTIMOS-----");
            string amigoEmprestimo = "";
            int amigosEmprestimosCadastrado = 0;
            bool amigoEncontrado = false;
            while (amigoEncontrado == false)
            {
                Console.Write("Digite o Nome do Amigo Que Está Emprestando a Revista: ");
                amigoEmprestimo = Console.ReadLine();
                for (int i = 0; i < amigo.Length; i++)
                {
                    if (amigo[i].nomeAmigo != amigoEmprestimo)
                    {
                        break;
                    }

                    if (amigoEmprestimo == amigo[i].nomeAmigo)
                    {
                        amigoEncontrado = true;
                        amigosEmprestimosCadastrado++;
                        break;
                    }
                    
                }

                if (amigosEmprestimosCadastrado == 0)
                {
                    Console.WriteLine("O Amigo Que Está Sendo Procurado Não Está Cadastrado");
                    Console.ReadLine();
                    continue;
                }
            }

            string revistaEmprestimo = "";
            int revistaEmprestimosCadastrado = 0;
            bool revistaEncontrada = false;
            while (revistaEncontrada == false)
            {
                Console.Write("Digite o Nome da Revista Emprestada: ");
                revistaEmprestimo = Console.ReadLine();
                for (int i = 0; i < revista.Length; i++)
                {
                    if (revista[i].tipoDaRevista != revistaEmprestimo)
                    {
                        break;
                    }

                    if (revistaEmprestimo == revista[i].tipoDaRevista)
                    {
                        revistaEncontrada = true;
                        revistaEmprestimosCadastrado++;
                        break;
                    }
                }

                if (revistaEmprestimosCadastrado == 0)
                {
                    Console.WriteLine("A Revista Que Está Sendo Procurada Não Está Cadastrada");
                    Console.ReadLine();
                    continue;
                }
            }
           

            Console.Write("Digite a Data do Emprestimo: ");
            DateTime dataEmprestimo = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a Data de Devolução: ");
            DateTime dataDevolução = Convert.ToDateTime(Console.ReadLine());

            TimeSpan intervaloDeReserva = dataDevolução - dataEmprestimo; //calculos dos dias 

            double intervalo =  intervaloDeReserva.Days;

           

            for (int i = 0; i < emprestimo.Length; i++) 
            {
                if (intervalo > categoria[i].qtdDiasEmprestimo)
                {
                    Console.WriteLine("entregue com atraso");
                    break;
                }
                if (intervalo < categoria[i].qtdDiasEmprestimo)
                {
                    Console.WriteLine("entregue no prazo");
                    break;
                }
            }

            novoEmprestimo.amigoQueEmprestou = amigoEmprestimo;
            novoEmprestimo.revistaQueEmprestou = revistaEmprestimo;
            novoEmprestimo.dataQueEmprestou = dataEmprestimo;
            novoEmprestimo.dataQueDevolveu = dataDevolução;

            for (int i = 0; i < amigo.Length; i++)
            {
                if (emprestimo[i] == null)
                {
                    emprestimo[i] = novoEmprestimo;
                    break;
                }
            }
        }
    

        public void VisualizarEmprestimos()
        {
            Console.Clear();
            int numeroEmprestimosCadastrados = 0;

            Console.WriteLine("VISUALIZAR EMPRÉSTIMOS-----");
            Console.WriteLine();
            for (int i = 0; i < emprestimo.Length; i++)
            {
                
                if (emprestimo[i] != null)
                {
                    Console.WriteLine("Amigo Que Emprestou: " + emprestimo[i].amigoQueEmprestou);
                    Console.WriteLine("Nome da Revista: " + emprestimo[i].revistaQueEmprestou);
                    Console.WriteLine("Data de Empréstimo: " + emprestimo[i].dataQueEmprestou.ToString("dd/MM/yy"));
                    Console.WriteLine("Data de Devolução: " + emprestimo[i].dataQueDevolveu.ToString("dd/MM/yy"));
                    Console.WriteLine("Status do Empréstimo: " + Emprestimo.StatusDeEmprestimo.Aberto);
                    Console.WriteLine();
                    numeroEmprestimosCadastrados++;
                }
            }
            if (numeroEmprestimosCadastrados == 0)
            {
                Console.WriteLine("Nenhum  Emprestimo foi cadastrado");
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }
              
        }
        public void VisualizarEmprestimosDoMes()
        {
            VisualizarEmprestimos();
          
            int numeroEmprestimosCadastrados = 0;
            Console.WriteLine("VISUALIZAR EMPRÉSTIMOS DO MÊS-----");
            Console.WriteLine();
            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] != null)
                {
                    Console.WriteLine("Insira o mês que deseja visualizar os empréstimos");
                    string strMes = Console.ReadLine();
                    int mes = Convert.ToInt32(strMes);

                    if (emprestimo[i].dataQueEmprestou.Month == mes)
                    {
                        Console.WriteLine("Amigo Que Emprestou: " + emprestimo[i].amigoQueEmprestou);
                        Console.WriteLine("Nome da Revista: " + emprestimo[i].revistaQueEmprestou);
                        Console.WriteLine("Data de Empréstimo: " + emprestimo[i].dataQueEmprestou.ToString("dd/MM/yy"));
                        Console.WriteLine("Data de Devolução: " + emprestimo[i].dataQueDevolveu.ToString("dd/MM/yy"));
                        Console.WriteLine();
                        numeroEmprestimosCadastrados++;
                    }
                }
            }
            if (numeroEmprestimosCadastrados == 0)
            {
                Console.WriteLine("Nenhum  Emprestimo Foi Cadastrado Neste Mês");
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }
          
        }
        #endregion

        #region   RESERVA

        public void CadastrarReserva()
        {
            VisualizarAmigo();
            VisualizarRevista();
            Reserva novaReserva = new Reserva();
            
            Console.Clear();

            Console.WriteLine("CADASTRO DAS RESERVAS DE REVISTA-----");

            string amigoReservando = "";
            int amigosReservandoCadastrados = 0;
            bool amigoEncontrado = false;
            while (amigoEncontrado == false)
            {
                Console.Write("Digite o Nome do Amigo Que Está Reservando a Revista: ");
                amigoReservando = Console.ReadLine();
                for (int i = 0; i < reserva.Length; i++)
                {
                    if (amigo[i].nomeAmigo != amigoReservando)
                    {
                        break;
                    }

                    if (amigoReservando == amigo[i].nomeAmigo)
                    {
                        amigoEncontrado = true;
                        amigosReservandoCadastrados++;
                        break;
                    }

                }
                if (amigosReservandoCadastrados == 0)
                {
                    Console.WriteLine("O Amigo Que Está Sendo Procurado Não Está Cadastrado");
                    Console.ReadLine();
                    continue;
                }
            }

            string revistaReserva = "";
            int revistaReservaCadastrada = 0;
            bool revistaEncontrada = false;
            while (revistaEncontrada == false)
            {
                Console.Write("Digite o Nome da Revista Reservada: ");
                revistaReserva = Console.ReadLine();
                for (int i = 0; i < reserva.Length; i++)
                {
                    if (revista[i].tipoDaRevista != revistaReserva)
                    {
                        break;
                    }

                    if (revistaReserva == revista[i].tipoDaRevista)
                    {
                        revistaEncontrada = true;
                        revistaReservaCadastrada++;
                        break;
                    }
                }

                if (revistaReservaCadastrada == 0)
                {
                    Console.WriteLine("A Revista Que Está Sendo Procurada Não Está Cadastrada");
                    Console.ReadLine();
                    continue;
                }
            }
           
            //string revistaReserva = "";
            //int revistaReservaCadastrada = 0;
            bool dataEncontrada = false;
            while (dataEncontrada == false)
            {
                Console.Write("Digite a Data da Reserva: ");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
                TimeSpan diferenca = DateTime.Today - data;
                double dias = diferenca.TotalDays;

                if (dias <= 2)
                {
                    novaReserva.amigoDaReserva = amigoReservando;
                    novaReserva.revistaReservada = revistaReserva;
                    novaReserva.dataDaReserva = data;
                    dataEncontrada = true;
                    Console.WriteLine("Reservado");
                    Console.ReadLine();
                    EmprestimoDeLivros();
                }

                else if (dias > 2)
                {
                    Console.WriteLine("Tempo de Reserva Já Está Expirado");
                    Console.ReadLine();
                    continue;
                }

            }

            for (int i = 0; i < reserva.Length; i++)
            {
                if (reserva[i] == null)
                {
                    reserva[i] = novaReserva;
                    break;
                }
            }

        }
        #endregion

        #region        CATEGORIA
        public void CategoriaRevista()
        {
            Categoria novaCategoria = new Categoria();
            
            Console.WriteLine("CADASTRO DE CATEGORIA-----");

            Console.Write("Digite a Categoria da Revista: ");
            string categoriaNome = Convert.ToString(Console.ReadLine());

            Console.Write("Digite a Quantidade de Dias do Empéstimo: ");
            double diasEmprestimo  = Convert.ToInt32(Console.ReadLine());
            

            string revistaCategoria = "";
            int revistaCategoriaCadastrada = 0;
            bool revistaEncontrada = false;
            while (revistaEncontrada == false)
            {
                Console.Write("Digite o Nome da Revista a Ser Adicionada a Uma Categoria: ");
                revistaCategoria = Console.ReadLine();
                for (int i = 0; i < reserva.Length; i++)
                {
                    if (revista[i].tipoDaRevista != revistaCategoria)
                    {
                        break;
                    }

                    if (revistaCategoria == revista[i].tipoDaRevista)
                    {
                        revistaEncontrada = true;
                        revistaCategoriaCadastrada++;
                        break;
                    }
                }

                if (revistaCategoriaCadastrada == 0)
                {
                    Console.WriteLine("A Revista Que Está Sendo Procurada Não Está Cadastrada");
                    Console.ReadLine();
                    continue;
                }
            }

            novaCategoria.nomeCategoria = categoriaNome;
            novaCategoria.qtdDiasEmprestimo = diasEmprestimo;
            novaCategoria.revistasCategoria = revistaCategoria;

            for (int i = 0; i < categoria.Length; i++)
            {
                if (categoria[i] == null)
                {
                    categoria[i] = novaCategoria;
                    break;
                }
            }
        }
        #endregion


    }
}
