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
                if (people.Count < 14) { people.Remove(people[qual - 1]); }
                else if (people.Count < 11) { people.Remove(people[qual - 3]); }
                else { people.Remove(people[qual]); }
                Console.WriteLine("REGISTRO REMOVIDO!");
            }
            catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
        }
        //Metodo para salvar os registros
        public static void Salvar(List<Register> people)
        {
            Guid g;
            g = Guid.NewGuid();
            string path = $@"C:\Users\guibo\Desktop\Ativ\AtividadeDia24-07\ArquivoJson\Arquivo{g}";
            StreamWriter sw2 = new StreamWriter(path);
            string g2 = JsonConvert.SerializeObject(people);
            sw2.WriteLine(g2);
            sw2.Close();
        }
    }
}
