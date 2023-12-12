using exEcomendasTutorial5.entidies;
using System;
using System.Collections.Generic;
using exEcomendasTutorial5.entidies.enums;

namespace exEcomendasTutorial5
{
    internal class Program
    {
        static public List<Client> listaClientes = new List<Client>();
        static public List<Product> listaProducts = new List<Product>();
        static public List<onder> ListaEncomdendas = new List<onder>();
        static void Main(string[] args)
        {

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("MENU: ");
                Console.WriteLine("1. Criar Cliente");
                Console.WriteLine("2. Apresentar Cliente");
                Console.WriteLine("3. Inserir Cliente");
                Console.WriteLine("4. Apresentar Produto");
                Console.WriteLine("5. Inserir Encomenda");
                Console.WriteLine("6. Apresentar Encomendas");
                Console.WriteLine("7. Sair");
                Console.Write("Opção: ");
                string op = Console.ReadLine();


                switch (op)
                {
                    case "1":
                        InserirCliente();
                        break;
                    case "2":
                        ApresentarClientes();
                        break;
                    case "4":
                        AprensentarProdutos();
                        break;
                    case "5":
                        InserirEncomenda();
                        break;
                    case "6":
                        apresentarEncomendas();
                        break;
                    case "7":
                        break;
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

        }
        static public void InserirCliente()
        {
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Client cliente = new Client(nomeCliente, emailCliente, dataNasc);
            listaClientes.Add(cliente);
            Console.WriteLine("Cliente inserido com sucesso!");

        }
        static public void ApresentarClientes()
        {
            Console.WriteLine("Lista de Cliente no Sistema");
            foreach (Client cl in listaClientes)
                Console.WriteLine(cl.ToString());
        }
        static public void InserirProdutos()
        {

            Console.Write("Nome do Produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Preço (PVP): ");
            double pvp = double.Parse(Console.ReadLine());
            Product produto = new Product(nomeProduto, pvp);
            listaProducts.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso");
        }
        static public void AprensentarProdutos()
        {
            Console.WriteLine("\n\nLista de Produtos no Sistema: ");
            foreach (Product pd in listaProducts)
                Console.WriteLine(pd.ToString());
        }
        static public void InserirEncomenda()
        {
            Console.WriteLine("\n\nEstado da Encomenda:");
            Console.Write("estado da encomenda (0- pendente,1-processado 2-em envio, 3 entregue):");
            OnderStatus os = (OnderStatus)Enum.Parse(typeof(OnderStatus), Console.ReadLine());

            DateTime dt = DateTime.Now;

            Console.WriteLine("\nSelecione o cliente proprietario da encomenda:");
            for(int i = 0; i < listaProducts.Count; i++)
                Console.WriteLine($"{i} - {listaClientes[i].name}");
            Console.Write("indice do cliente:");
            int id = int.Parse(Console.ReadLine());
            if( id>=0 && id<listaClientes.Count )
            {
                onder onder = new onder(dt, os, listaClientes[id]);
                ListaEncomdendas.Add(onder);
                bool inseriritem = true;
                while( inseriritem )
                {
                    Console.WriteLine("\nSelecione o produto:");
                    for (int i = 0; i < listaClientes.Count; i++)
                        Console.WriteLine($"{i} - {listaProducts[i].Name}");
                            Console.Write("indice dos produtos:");
                    id = int.Parse(Console.ReadLine());
                    if ( id>=0 && id <listaProducts.Count )
                    {
                        Product p = listaProducts[id];
                        Console.Write("Quantidade:");
                        int qt = int.Parse(Console.ReadLine());
                        Console.Write("preço:");
                        double preco = double.Parse(Console.ReadLine());
                        onder.AddItem(new onderItem(p, qt, preco));
                        Console.Write("adicionar novo item? s/n:");
                        if (Console.ReadLine().ToUpper() != "s") inseriritem=false;
                    }
                    else
                        Console.WriteLine("indice de produto invalido!");
                }
            }
            else
                Console.WriteLine("indice de produto invalido!");
        }
        static public void apresentarEncomendas()
        {
            Console.WriteLine("\n\nLista de encomendas no sistema:");
            foreach(onder or in ListaEncomdendas)
                Console.WriteLine(or.ToString());
        }

    }
}