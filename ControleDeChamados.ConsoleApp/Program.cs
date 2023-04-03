using System.Collections;

namespace ControleDeChamados.ConsoleApp
{
    internal class Program
    {
        //equipamento

        static ArrayList nomeEquipamento = new ArrayList();
        static ArrayList idEquipamento = new ArrayList();
        static ArrayList numerosDeSerieEquipamento = new ArrayList();
        static ArrayList precoEquipamento = new ArrayList();
        static ArrayList fabricanteEquipamento = new ArrayList();
        static ArrayList dataDeFabricacaoEquipamento = new ArrayList();

        static int idEquipamentos = 0;

        //chamado

        static ArrayList tituloChamado = new ArrayList();
        static ArrayList idChamado = new ArrayList();
        static ArrayList descricaoChamado = new ArrayList();
        static ArrayList dataDeAberturaChamado = new ArrayList();
        static ArrayList equipamentoChamado = new ArrayList();

        static int idChamados = 0;

        static void Main(string[] args)
        {
            //equipamento

            nomeEquipamento.Add("Impressora");
            idEquipamento.Add(0);
            numerosDeSerieEquipamento.Add(001);
            precoEquipamento.Add(2000);
            fabricanteEquipamento.Add("HP");
            dataDeFabricacaoEquipamento.Add("24/12/2007");

            nomeEquipamento.Add("Notebook");
            idEquipamento.Add(1);
            numerosDeSerieEquipamento.Add(002);
            precoEquipamento.Add(5000);
            fabricanteEquipamento.Add("Acer");
            dataDeFabricacaoEquipamento.Add("02/02/2012");

            nomeEquipamento.Add("Celular");
            idEquipamento.Add(2);
            numerosDeSerieEquipamento.Add(003);
            precoEquipamento.Add(2000);
            fabricanteEquipamento.Add("Samsung");
            dataDeFabricacaoEquipamento.Add("05/09/2021");

            //chamados

            idChamado.Add(0);
            descricaoChamado.Add("impressora estragou");
            tituloChamado.Add("Impressora ruim");
            equipamentoChamado.Add(0);
            dataDeAberturaChamado.Add("05/09/2022");

            idChamado.Add(1);
            descricaoChamado.Add("tela azul");
            tituloChamado.Add("Tela Azul");
            equipamentoChamado.Add(1);
            dataDeAberturaChamado.Add("06/10/2022");

            idChamado.Add(2);
            descricaoChamado.Add("Botão de inicio estragou");
            tituloChamado.Add("Botão quebrou");
            equipamentoChamado.Add(2);
            dataDeAberturaChamado.Add("10/04/2022");


            idEquipamentos = idEquipamento.Count;
            idChamados = idChamado.Count;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("(1) Gerenciar equipamentos ");
                Console.WriteLine("(2) Gerenciar chamados ");
                Console.WriteLine("(S) Sair ");

                string opcaoMenu = Console.ReadLine();

                if (opcaoMenu.ToUpper() == "S")
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                switch (opcaoMenu.ToUpper())
                {
                    case "1": MenuEquipamentos(nomeEquipamento, idEquipamento, numerosDeSerieEquipamento, precoEquipamento, fabricanteEquipamento, dataDeFabricacaoEquipamento); break;
                    case "2": MenuChamados(idEquipamento, idChamado, tituloChamado, descricaoChamado, dataDeAberturaChamado, equipamentoChamado); break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nopção inválida \n");
                        Console.ResetColor(); break;
                }
            }
        }

        static void MenuEquipamentos(ArrayList nomeEquipamento, ArrayList idEquipamento, ArrayList numerosDeSerieEquipamento, ArrayList precoEquipamento, ArrayList fabricanteEquipamento, ArrayList dataDeFabricacaoEquipamento)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("(1) Adicionar um equipamento");
                Console.WriteLine("(2) Editar um equipamento");
                Console.WriteLine("(3) Excluir um equipamento");
                Console.WriteLine("(4) Listar equipamentos existentes");
                Console.WriteLine("(V) Voltar ao menu");

                string opcaoEquipamento = Console.ReadLine();

                if (opcaoEquipamento.ToUpper() == "V")
                {
                    Console.WriteLine("Voltando ao menu principal");
                    break;
                }

                switch (opcaoEquipamento.ToUpper())
                {
                    case "1": CriacaoEquipamento(nomeEquipamento, idEquipamento, numerosDeSerieEquipamento, precoEquipamento, fabricanteEquipamento, dataDeFabricacaoEquipamento); break;
                    case "2": EdicaoEquipamento(nomeEquipamento, idEquipamento, numerosDeSerieEquipamento, precoEquipamento, fabricanteEquipamento, dataDeFabricacaoEquipamento); break;
                    case "3": RemocaoEquipamento(nomeEquipamento, idEquipamento, numerosDeSerieEquipamento, precoEquipamento, fabricanteEquipamento, dataDeFabricacaoEquipamento); break;
                    case "4": ListaEquipamento(); break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nopção inválida \n");
                        Console.ResetColor(); break;
                }
            }
        }

        static void MenuChamados(ArrayList idEquipamento, ArrayList idChamado, ArrayList tituloChamado, ArrayList descricaoChamado, ArrayList dataDeAberturaChamado, ArrayList equipamentoChamado)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("(1) Criar um chamado");
                Console.WriteLine("(2) Editar um chamado");
                Console.WriteLine("(3) Excluir um chamado");
                Console.WriteLine("(4) Listar chamados existentes");
                Console.WriteLine("(V) Voltar ao menu");

                string opcaoChamado = Console.ReadLine();

                if (opcaoChamado.ToUpper() == "V")
                {
                    Console.WriteLine("Voltando ao menu principal");
                    break;
                }
                switch (opcaoChamado.ToUpper())
                {
                    case "1": CriacaoChamado(idChamado, tituloChamado, descricaoChamado, dataDeAberturaChamado, equipamentoChamado); break;
                    case "2": EdicaoChamado(idChamado, tituloChamado, descricaoChamado, dataDeAberturaChamado, equipamentoChamado); break;
                    case "3": RemocaoChamado(idChamado, tituloChamado, descricaoChamado, dataDeAberturaChamado, equipamentoChamado); break;
                    case "4": ListaChamado(); break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nopção inválida \n");
                        Console.ResetColor(); break;
                }
            }
            Console.Clear();
        }

        //Equipamento

        static void CriacaoEquipamento(ArrayList nomeEquipamento, ArrayList idEquipamento, ArrayList numerosDeSerieEquipamento, ArrayList precoEquipamento, ArrayList fabricanteEquipamento, ArrayList dataDeFabricacaoEquipamento)
        {
            Console.Clear();
            Console.Write("Nome do equipamento: ");
            string nome = Console.ReadLine();

            while (nome.Length < 6)
            {
                Console.WriteLine("O nome do equipamento deve ter no mínimo 6 caracteres. ");
                Console.WriteLine("Digite novamente: ");

                nome = Console.ReadLine();
            }
            nomeEquipamento.Add(nome);

            Console.Write("Número de série: ");
            int numero = int.Parse(Console.ReadLine());
            numerosDeSerieEquipamento.Add(numero);

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            precoEquipamento.Add(preco);

            Console.Write("Data de fabricação: ");
            string dataDeFabricacao = Console.ReadLine();
            dataDeFabricacaoEquipamento.Add(dataDeFabricacao);

            Console.Write("Fabricante: ");
            string fabricante = Console.ReadLine();
            fabricanteEquipamento.Add(fabricante);

            idEquipamento.Add(idEquipamentos);
            idEquipamentos++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEquipamento registrado com sucesso! ");
            Console.ResetColor();
            Console.ReadKey();

        }

        static void EdicaoEquipamento(ArrayList nomeEquipamento, ArrayList idEquipamento, ArrayList numerosDeSerieEquipamento, ArrayList precoEquipamento, ArrayList fabricanteEquipamento, ArrayList dataDeFabricacaoEquipamento)
        {
            Console.Clear();
            ListaEquipamento();

            Console.Write("\nDigite o ID do equipamento que deseja editar: ");
            int idEditar = int.Parse(Console.ReadLine());

            while (idEditar > idEquipamento.Count || idEditar < 0)
            {
                Console.WriteLine("Equipamento não existe!");
                Console.WriteLine();
                Console.WriteLine("Digite o ID do equipamento que deseja editar: ");
                idEditar = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEscolha a opção que será editada\n");
            Console.WriteLine("(1) Nome");
            Console.WriteLine("(2) Preço");
            Console.WriteLine("(3) Fabricante");
            Console.WriteLine("(4) Data de fabricação");
            Console.WriteLine("(5) Número de série");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Write("Edite o nome: ");
                    string novoNome = Console.ReadLine();
                    nomeEquipamento[idEditar] = novoNome;
                    mensagem();
                    break;

                case "2":
                    Console.Write("Edite o preço do equipamento: ");
                    double novoPreco = double.Parse(Console.ReadLine());
                    precoEquipamento[idEditar] = novoPreco;
                    mensagem();
                    break;

                case "3":
                    Console.WriteLine("Edite o fabricante do equipamento: ");
                    string novoFabricante = Console.ReadLine();
                    fabricanteEquipamento[idEditar] = novoFabricante;
                    mensagem();
                    break;

                case "4":
                    Console.WriteLine("Edite a data de fabricação do equipamento: ");
                    DateTime novaData = DateTime.Parse(Console.ReadLine());
                    dataDeFabricacaoEquipamento[idEditar] = novaData;
                    mensagem();
                    break;

                case "5":
                    Console.WriteLine("Edite o número de série do equipamento: ");
                    string novaSerie = Console.ReadLine();
                    numerosDeSerieEquipamento[idEditar] = novaSerie;
                    mensagem();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nopção inválida \n");
                    Console.ResetColor(); break;

            }
        }

        static void RemocaoEquipamento(ArrayList nomeEquipamento, ArrayList idEquipamento, ArrayList numerosDeSerieEquipamento, ArrayList precoEquipamento, ArrayList fabricanteEquipamento, ArrayList dataDeFabricacaoEquipamento)
        {
            Console.Clear();
            ListaEquipamento();

            Console.Write("\nDigite o ID do equipamento que deseja remover: ");
            int removerEquipamento = int.Parse(Console.ReadLine());

            while (removerEquipamento > idEquipamento.Count || removerEquipamento < 0)
            {
                Console.WriteLine("Equipamento não existe!");
                Console.WriteLine("\nDigite o ID que deseja excluir: ");
                removerEquipamento = int.Parse(Console.ReadLine());
            }

            nomeEquipamento.RemoveAt(removerEquipamento);
            precoEquipamento.RemoveAt(removerEquipamento);
            idEquipamento.RemoveAt(removerEquipamento);
            numerosDeSerieEquipamento.RemoveAt(removerEquipamento);
            fabricanteEquipamento.RemoveAt(removerEquipamento);
            dataDeFabricacaoEquipamento.RemoveAt(removerEquipamento);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sucesso!");
            Console.ResetColor();
            Console.ReadLine();

        }

        static void ListaEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Equipamentos registrados:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|ID |Número de série|Nome           |Preço     |Fabricante     |Data de Fabricação  |");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.ResetColor();

            for (int i = 0; i < idEquipamento.Count; i++)
            {
                Console.WriteLine("|{0,-3}|{1,-15}|{2,-15}|{3,-10}|{4,-15}|{5,-20}|", idEquipamento[i], numerosDeSerieEquipamento[i], nomeEquipamento[i], precoEquipamento[i], fabricanteEquipamento[i], dataDeFabricacaoEquipamento[i]);
            }
            Console.ReadKey();
        }

        //Chamado

        static void CriacaoChamado(ArrayList idChamado, ArrayList tituloChamado, ArrayList descricaoChamado, ArrayList dataDeAberturaChamado, ArrayList equipamentoChamado)
        {

            Console.Write("Digite o titulo: ");
            string titulo = Console.ReadLine();
            tituloChamado.Add(titulo);

            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine();
            descricaoChamado.Add(descricao);

            Console.Write("Digite o ID do equipamento que será usado: ");
            int equipamento = int.Parse(Console.ReadLine());
            equipamentoChamado.Add(equipamento);


            Console.Write("Digite a data de abertura: (00/00/0000)");
            DateTime dataAbertura = DateTime.Parse(Console.ReadLine());
            dataDeAberturaChamado.Add(dataAbertura);

            idChamado.Add(idChamados);
            idChamados++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nChamado registrado com sucesso! ");
            Console.ResetColor();
            Console.ReadKey();
        }

        static void EdicaoChamado(ArrayList idChamado, ArrayList tituloChamado, ArrayList descricaoChamado, ArrayList dataDeAberturaChamado, ArrayList equipamentoChamado)
        {
            Console.Clear();
            ListaChamado();

            Console.Write("\nDigite o ID do chamado que deseja editar: ");
            int idEditarChamado = int.Parse(Console.ReadLine());

            while (idEditarChamado > idChamado.Count || idEditarChamado < 0)
            {
                Console.WriteLine("Chamado não existe!");
                Console.WriteLine();
                Console.WriteLine("Digite o ID do chamado que deseja editar: ");
                idEditarChamado = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEscolha a opção que será editada\n");
            Console.WriteLine("(1) Título");
            Console.WriteLine("(2) Descrição");
            Console.WriteLine("(3) Equipamento");
            Console.WriteLine("(4) Data de abertura");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Write("Edite o título do chamado: ");
                    string novoTitulo = Console.ReadLine();
                    tituloChamado[idEditarChamado] = novoTitulo;
                    mensagem();
                    break;

                case "2":
                    Console.Write("Edite a descrição do chamado: ");
                    string novaDescricao = Console.ReadLine();
                    descricaoChamado[idEditarChamado] = novaDescricao;
                    mensagem();
                    break;

                case "3":
                    Console.WriteLine("Edite o equipamento do chamado pelo ID: ");
                    int novoId = int.Parse(Console.ReadLine());
                    equipamentoChamado[idEditarChamado] = novoId;
                    mensagem();
                    break;

                case "4":
                    Console.WriteLine("Edite a data de abertura do chamado: ");
                    DateTime novaDataChamado = DateTime.Parse(Console.ReadLine());
                    dataDeAberturaChamado[idEditarChamado] = novaDataChamado;
                    mensagem();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nopção inválida \n");
                    Console.ResetColor(); break;

            }
        }

        static void RemocaoChamado(ArrayList idChamado, ArrayList tituloChamado, ArrayList descricaoChamado, ArrayList dataDeAberturaChamado, ArrayList equipamentoChamado)
        {
            Console.Clear();
            ListaChamado();

            Console.Write("\nDigite o ID do equipamento que deseja remover: ");
            int removerChamado = int.Parse(Console.ReadLine());

            while (removerChamado > idChamado.Count || removerChamado < 0)
            {
                Console.WriteLine("Chamado não existe!");
                Console.WriteLine("\nDigite o ID que deseja excluir: ");
                removerChamado = int.Parse(Console.ReadLine());
            }

            tituloChamado.RemoveAt(removerChamado);
            descricaoChamado.RemoveAt(removerChamado);
            equipamentoChamado.RemoveAt(removerChamado);
            dataDeAberturaChamado.RemoveAt(removerChamado);
            idChamado.RemoveAt(removerChamado);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sucesso!");
            Console.ResetColor();
            Console.ReadLine();
        }

        static void ListaChamado()
        {
            Console.Clear();
            Console.WriteLine("Chamados registrados:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|ID |Titulo             |Equipamento         |Data de Abertura         |");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ResetColor();

            for (int i = 0; i < idChamado.Count; i++)
            {
                int posicaoIdEquipamento = (int)equipamentoChamado[i];
                Console.WriteLine("|{0,-3}|{1,-19}|{2,-20}|{3,-25}|", idChamado[i], tituloChamado[i], nomeEquipamento[posicaoIdEquipamento], dataDeAberturaChamado[i]);
            }
            Console.ReadKey();
        }

        static void mensagem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSucesso! \n");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}





