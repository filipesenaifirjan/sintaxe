using sintaxe_em_c_.Models; //aqui se trata de um caminho (lógico) que não é referenciado em pastas (não precisa)

//Obs: Se a sua classe não estiver sendo reconhecida, presta atenção no namespace

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//string apresentacao = "Olá, não seja bem vindo e não venha";
//int quantidade = 1; 
//Console.WriteLine("Valor da variável quantidade: " + quantidade);//nesse caso ela lê pq estou dando ordem pra imprimir esse resultado antes de ler o de baixo

//quantidade = 10;// nesse caso ele passa o valor para 10 pe ele lê a segunda linha após a primeira
//Console.WriteLine("Valor da variável quantidade: " + quantidade); //int está declarado acima e não precisa e nem pode declarar int novamente

//double altura = 1.90; //o double não é recomendado nesse caso pq ele ingora o zero nesse caso
//decimal preco = 10.35M;
//bool condicao = true;





//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura);
//Console.WriteLine("Valor da variável preco: " + preco);
//Console.WriteLine("Valor da variável condicao: " + condicao);

            //a variável(pessoa1) começa com letra minúscula e se tiver mais de uma palavra, aí sim usa letra maiúscula
//Pessoa pessoa1 = new Pessoa(); //a pessoa1 pode levar qualquer nome, ali é o nome da variável, vc pode modificar, pois se trata de uma instância.. lemnbra que aqui não é o nome da pessoa, e sim o nome da variável, o endereço na memória ok

//pessoa1.Nome = "Filipe"; //passando os dados
//pessoa1.Idade = 15;//passando os dados 
//pessoa1.Apresentar(); //apresentar é um método e por isso tem ()
//outro detalhe importante é o .(dot) que mostra o que vc pode fazer com a (pessoa1) sempre que add algo, mudar a variavel, chamar metodo, tem que colocar o .(dot)
//todo final de comando tem que ter ; 
//Pra pular uma linha dentro do código, vc fecha a string com aspas dupla e acrescenta o + MAS isso só acontece no código
//no caso de quebra de linha na execução, acrescenta o \n 
//outro detalhe, o compilador vai ignorar qualquer espaço que vc der dentro do seu código ou quebra de linha dentro do código

//seguindo com exemplos: camelCase PascalCase  snake_case spinal-case, repara que, cada um tem uma sintaxe diferente
//nome de classe, propriedade e método é sempre em PascalCase
//a convenção não vai travar seu código, mas é importante seguir a convenção de cada linguagem assim a gente mantém o padrão e não bagunça o código
//nome de variáveis e classes, a gente nunca abrevia, é recomendável que vc escreva sempre o nome por extenso
//Boas práticas... ter o nome da classe igual o nome do arquivo, ex: Pessoa.cs como arquivo e classe Pessoa
//não pode ter caracteres especiais nas variáveis, classes e propriedades, o único que é aceitável é 0 _ por conta do snake_case, nesse caso, ele vai interpretar como snake_case