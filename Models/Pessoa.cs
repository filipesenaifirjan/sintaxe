using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe_em_c_.Models
{
    public class Pessoa //uma classe, nada mais é que um molde que vc quer representar
    {
        public string Nome {get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho  {Idade} anos");
        }
    }
}