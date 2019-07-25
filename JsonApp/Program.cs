using JsonApp.Entidades.JsonClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtendo e deserializando o objeto.
            string targetPath = @"C:\Users\guibo\Desktop\Ativ\AtividadeDia24-07\ArquivoJson\Trabalho.json";
            var file = File.ReadAllText(targetPath);
            var people = JsonConvert.DeserializeObject<List<Register>>(file);

            Console.WriteLine("SEJA BEM VINDO");
            while (true)
            {
                //Menu e interação com o usuario.

                Console.WriteLine("DIGITE 1 PARA MOSTRAR REGISTROS, 2 PARA REMOVER REGISTROS E 3 PARA SALVAR OU 4 PARA SAIR ");
                Int32.TryParse(Console.ReadLine(), out int opcao);

                if (opcao == 1) { Operacoes.MostrarRegistro(people); }
                else if (opcao == 2)
                {
                    Console.WriteLine("Qual item da lista deseja remover ? escolha pelo Index");
                    Int32.TryParse(Console.ReadLine(), out int qual);

                    while (qual < 0 || qual > 13)
                    {
                        Console.WriteLine("Indice invalido, digitar novamente!");
                        Int32.TryParse(Console.ReadLine(), out qual);
                    }
                    Operacoes.Remover(people, qual);
                }
                else if (opcao == 3)
                {
                    Operacoes.Salvar(people);
                    Console.WriteLine("ALTERAÇÕES SALVAS EM NOVO ARQUIVO!");
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("OBRIGADO E ATE MAIS, ");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
