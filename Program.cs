using sintaxe_em_c_.Models; //aqui se trata de um caminho (lógico) que não é referenciado em pastas (não precisa)
//Obs: Se a sua classe não estiver sendo reconhecida, presta atenção no namespace

Pessoa pessoa1 = new Pessoa(); //a pessoa1 pode levar qualquer nome, ali é o nome da variável, vc pode modificar, pois se trata de uma instância.. lemnbra que aqui não é o nome da pessoa, e sim o nome da variável, o endereço na memória ok

pessoa1.Nome = "Filipe"; //passando os dados
pessoa1.Idade = 15;//passando os dados 
pessoa1.Apresentar(); //apresentar é um método e por isso tem ()
//outro detalhe importante é o .(dot) que mostra o que vc pode fazer com a (pessoa1) sempre que add algo, mudar a variavel, chamar metodo, tem que colocar o .(dot)
//todo final de comando tem que ter ; 
//Pra pular uma linha dentro do código, vc fecha a string com aspas dupla e acrescenta o + MAS isso só acontece no código
//no caso de quebra de linha na execução, acrescenta o \n 
//outro detalhe, o compilador vai ignorar qualquer espaço que vc der dentro do seu código ou quebra de linha dentro do código

//seguindo com exemplos: camelCase PascalCase  snake_case spinal-case, repara que, cada um tem uma sintaxe diferente