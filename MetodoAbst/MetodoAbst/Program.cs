using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbst
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente();
            string sair;

            do{
                Console.Clear();
                p.cadastro_pessoa();
                p.exibir_pessoa();
                Console.WriteLine("Para sair, escreva 'q'");
                sair = Console.ReadLine().ToUpper();

            }
            while (sair != "Q") ;
            
        }
    }
}
