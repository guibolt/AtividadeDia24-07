using JsonApp.Entidades.JsonClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonApp
{
    public static class Operacoes
    {
        //Metodo para exibir os registros
        public static void MostrarRegistro(List<Register> registers)
        {
            Att(registers);
            foreach (var item in registers){ Console.WriteLine(item.ToString());}
        }
        //Metodo para remover os registros
        public static void Remover(List<Register> people, int qual)
        {
            try
            {
                people.Remove(people[qual - 1]);
                Console.WriteLine("REGISTRO REMOVIDO!");
            }
            catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
        }
        //Metodo para salvar os registros
        public static void Salvar(List<Register> people)
        {
            string Lop = Guid.NewGuid().ToString();
            string path = $@"C:\Users\Treinamento 5\Desktop\AtividadeEntrega\ArquivoJson\ArquivoJson{Lop.Substring(0, 2)}.json";
            StreamWriter writter = new StreamWriter(path);
            string arq = JsonConvert.SerializeObject(people);
            writter.WriteLine(arq);
            writter.Close();
        }
        //Metodo para atualizar os indixes dos objetos
        public static void Att(List<Register> registers)
        {
            Console.WriteLine("REGISTROS COM INDICES ATUALIZADOS!\n");
            for (int i = 0; i < registers.Count; i++) { registers[i].Index = i;  }
        }
    }
}
