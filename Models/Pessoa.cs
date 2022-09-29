using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe_em_c_.Models
{
    public class Pessoa
    {
        public string Nome {get; set; }
        public int MyProperty { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($ "Olá, meu nome é {Nome}, e tenho  {Idade} anos");
        }
    }
}