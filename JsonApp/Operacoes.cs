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
            Console.WriteLine("REGISTROS:");
            Console.WriteLine("");
            Att(registers);
            foreach (var item in registers)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("");
            }
        }
        //Metodo para remover os registros
        public static void Remover(List<Register> people, int qual)
        {
            try
            {
               people.Remove(people[qual]);
                Console.WriteLine("REGISTRO REMOVIDO!");
            }
            catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
        }
        //Metodo para salvar os registros
        public static void Salvar(List<Register> people)
        {
            Guid g;
            g = Guid.NewGuid();
            string path = $@"C:\Users\Treinamento 5\Desktop\AtividadeEntrega\ArquivoJson\Arquivo{g}";
            StreamWriter sw2 = new StreamWriter(path);
            string g2 = JsonConvert.SerializeObject(people);
            sw2.WriteLine(g2);
            sw2.Close();
        }
        public static void Att(List<Register> registers)
        {
            Console.WriteLine("REGISTROS ATUALIZADOS!");
            for (int i = 0; i < registers.Count; i++)
            {
                registers[i].Index = i;
            }
            
        }
    }
}
