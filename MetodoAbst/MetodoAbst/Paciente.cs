using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbst
{
    class Paciente:Pessoa
    {
        public override void cadastro_pessoa()
        {
            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Quantos aninhos você tem? ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Insira seu email: ");
            email = Console.ReadLine();
            Console.ReadKey();
        }
        public override void exibir_pessoa()
        {
            Console.Clear();
            Console.WriteLine("Nome: {0}",nome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Email: {0}",email);
            Console.ReadKey();
        }
    }
}
