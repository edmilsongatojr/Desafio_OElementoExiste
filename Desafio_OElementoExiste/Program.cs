using System;
using System.Collections.Generic;

namespace Desafio_OElementoExiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> _nomesDosEscolhidos = new List<string>()
            {
                "Bruce Wayne",
                "Carlos Vilagran",
                "Richard Grayson",
                "Bob Kane",
                "Will Farrel",
                "Lois Lane",
                "General Welling",
                "Perla Letícia",
                "Uxas",
                "Diana Prince",
                "Elisabeth Romanova",
                "Anakin Wayne"
            };

            PainelDesafio();

            void CabecalhoDesafio()
            {
                Console.Clear();
                Console.WriteLine("_C# Trabalhando com Arrays e Coleções_ | @Desafio: o elemento existe?");
                Console.WriteLine("\n");
            }

            void PainelDesafio()
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    CabecalhoDesafio();
                    Console.WriteLine("1 - Lista de Nomes");
                    Console.WriteLine("2 - Verificar Nome na Lista");
                    Console.WriteLine("\n");
                    Console.Write("Selecione a opção desejada: ");
                    opcao = Console.ReadLine()[0];
                    switch (opcao)
                    {
                        case '1': ListarNomes();
                            break;
                        case '2': BuscarNome();
                            break;
                        default:
                            Console.WriteLine("Opcao não implementada. Selecione um opção válida!");
                            break;
                    }
                    Console.ReadKey();
                }
            }

            void ListarNomes()
            {
                CabecalhoDesafio();
                if (_nomesDosEscolhidos.Count <= 0)
                {
                    Console.WriteLine("ATENÇÃO! | Não existe nomes na lista!");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("[                    LISTA DE NOMES                   ]");
                Console.WriteLine("-------------------------------------------------------");

                int indice = 1;
                foreach (var item in _nomesDosEscolhidos)
                {
                    Console.WriteLine($"{indice} - {item}");
                    indice++;
                }   
                Console.WriteLine("=======================================================");
                Console.WriteLine("Pressione Enter para prosseguir...");
                Console.ReadKey();
            }

            void BuscarNome()
            {
                CabecalhoDesafio();
                Console.WriteLine("[                    BUSCA DE NOMES                   ]");
                Console.WriteLine("-------------------------------------------------------");
                Console.Write("Digite um Nome para Buscar:");
                string busca = Console.ReadLine();

                foreach (var item in _nomesDosEscolhidos)
                {

                    if (item.Equals(busca))
                    {
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Busca Realizada com Sucesso...");
                        Console.WriteLine($"Nome Encontrado: [ {busca} ]");
                        break;
                    }
                    else
                    {

                        Console.WriteLine($"Não encontramos nenhum nome igual à {busca}");
                        break;
                    }
                }
                Console.WriteLine("=======================================================");
                Console.WriteLine("Pressione Enter para prosseguir...");
                Console.ReadKey();
            }

        }

    }
}
