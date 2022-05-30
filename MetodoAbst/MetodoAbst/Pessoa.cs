using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbst
{
    abstract class Pessoa
    {
        protected string nome;
        protected int idade;
        protected string email;

        public abstract void cadastro_pessoa();
        public abstract void exibir_pessoa();
    }
}
