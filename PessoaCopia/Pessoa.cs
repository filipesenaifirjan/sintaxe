using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe_em_c_.Models.PessoaCopia
{
    public class Pessoa //uma classe, nada mais é que um molde (objeto da vida real) que vc quer representar, somente representação do que é no mundo real
    {
        public string Nome {get; set; }
        public int Idade { get; set; } //aqui temos atributos da classe pessoa

        public void Apresentar() // aqui temos o metodo, o que a pessoa vai fazer
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho  {Idade} anos");
        }
    }
}