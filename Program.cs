using sintaxe_em_c_.Models; //aqui se trata de um caminho (lógico) que não é referenciado em pastas (não precisa)
//Obs: Se a sua classe não estiver sendo reconhecida, presta atenção no namespace

Pessoa pessoa1 = new Pessoa(); //a pessoa1 pode levar qualquer nome, ali é o nome da variável, vc pode modificar, pois se trata de uma instância.. lemnbra que aqui não é o nome da pessoa, e sim o nome da variável, o endereço na memória ok

pessoa1.Nome = "Filipe";
pessoa1.Idade = 15;
pessoa1.Apresentar(); //apresentar é um método e por isso tem ()