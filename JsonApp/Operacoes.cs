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
            people.Remove(people[qual]);
         
        }
        //Metodo para salvar os registros
        public static void Salvar(List<Register> people)
        {
            int g = 0;
            
            string path = $@"C:\Users\Treinamento 5\Desktop\AtividadeEntrega\ArquivoJson\Arquivo{g+1}";
            StreamWriter sw2 = new StreamWriter(path);
            string g2 = JsonConvert.SerializeObject(people);
            sw2.WriteLine(g2);
            sw2.Close();
            g++;
          

        }

    }
}
