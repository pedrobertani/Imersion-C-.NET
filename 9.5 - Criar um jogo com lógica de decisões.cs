//Criando um jogo com lógica de decisões.

//Uma forma fácil de se aprender lógica de decisões e já  colocar o que aprendemos anteriormente em pratica
//É utilizando metodo, Random.next() para simular um jogo com rolagem de dados.


//Jogo da microsoft - Etapa 1

//Usaremos o método Random.Next() para simular a rolagem de três dados de seis lados cada.
//Avaliaremos os valores para calcular a pontuação.
//Se a pontuação for superior a um total arbitrário, exibiremos uma mensagem de vitória para o usuário.
//Caso contrário, exibiremos uma mensagem de derrota para o usuário.

//Se os dados rolados resultarem o mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.
//Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.
//Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for igual ou maior que 15, você vencerá o jogo.
//Caso contrário, você perderá.
//Nós aumentaremos o número de regras conforme expandirmos nossa compreensão da instrução if.


//Código que gera 3 números aleatórios.

Random dado = new Random();
int rolar1 = dado.Next(1, 7);
int rolar2 = dado.Next(1, 7);
int rolar3 = dado.Next(1, 7);

int total = rolar1 + rolar2 + rolar3;

Console.WriteLine($"Valores dos dados: {rolar1} + {rolar2} + {rolar3} = {total}");

//Criamos uma nova instância da classe System.Random e armazenamos a referência a esse objeto na variável dado.
//Em seguida, chamamos o método Random.Next() no objeto dado três vezes
//fornecendo os limites inferior e superior para restringir os valores possíveis ao intervalo entre 1 e 6.
//Salvamos os três números aleatórios nas variáveis rolar1, rolar2 e rolar3, respectivamente.
//Em seguida, somamos os valores referentes às três vezes em que os dados foram rolados e salvamos o resultado na variável total.
//Por fim, exibimos todos os valores usando a interpolação de cadeia de caracteres.

//Saída
//Valores dos dados: 4 + 6 + 1 = 11 

//Caso você rode o código os números serão diferentes.

//-----------------------------------------------------------------------------------------------------------------------------------

//Jogo da microsoft - Etapa 2

//Na segunda etapa utilizaremos a lógica de decisões " if " para exibir mensagens com base nos valores obitidos no total de pontos.

Random dado = new Random();
int rolar1 = dado.Next(1, 7);
int rolar2 = dado.Next(1, 7);
int rolar3 = dado.Next(1, 7);

int total = rolar1 + rolar2 + rolar3;

Console.WriteLine($"Valores dos dados: {rolar1} + {rolar2} + {rolar3} = {total}");

if (total > 14)
{
    Console.WriteLine("Você ganhou!");
}

if (total < 15)
{
    Console.WriteLine("Sinto muito, você perdeu.");
}

//Saída
//Valores dos dados: 3 + 1 + 3 = 7
//Sinto muito, você perdeu.

//Anos luz depois..

//Saída
//Valores dos dados: 6 + 4 + 5 = 15
//Você ganhou!


//Explicando código

//Adicionamos duas instruções if para lidar com os cenários de vitória e derrota. Vamos nos concentrar na primeira instrução if.

//A instrução if é composta por três partes:

//A palavra-chave if
//Uma expressão booliana entre parênteses ()
//Um bloco de código definido por chaves { }

//Em runtime, a expressão booliana total > 14 é avaliada.
//Se a instrução for verdadeira, se o valor de total for maior que: 14
//Ele irá entrar dentro do bloco if onde temos a condição, se isso for x então faça isso, se não siga em frente.
//Em outras palavras, ele executará o código entre as chaves ou seguira para proxima instrução
//Caso não tenha outra, ela finaliza execução.


//Em nosso exemplo, avaliamos a expressão booliana total > 14.
//No entanto, poderíamos ter escolhido a expressão booliana total >= 15
//Uma vez que neste caso elas são a mesma coisa.
//Considerando que as regras de nosso jogo especificam se:
//os dois dados, mais quaisquer bônus, somarem 15 ou mais você ganhará o jogo, provavelmente devemos preferir o último.

//-----------------------------------------------------------------------------------------------------------------------------------

//Jogo da microsoft - Etapa 3

//Em seguida, vamos implementar a regra:
//"Se dois dados rolados resultarem no mesmo valor você receberá dois pontos de bônus pelo resultado duplicado.

Random dado = new Random();
int rolar1 = dado.Next(1, 7);
int rolar2 = dado.Next(1, 7);
int rolar3 = dado.Next(1, 7);

int total = rolar1 + rolar2 + rolar3;

Console.WriteLine($"Valores dos dados: {rolar1} + {rolar2} + {rolar3} = {total}");

if ((rolar1 == rolar2) || (rolar2 == rolar3) || (rolar1 == rolar3))
{
    Console.WriteLine("Você rolou dados iguais! ganhou +2 pontos de bonus!");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine("Você ganhou!");
}

if (total < 15)
{
    Console.WriteLine("Sinto muito, você perdeu.");
}

//Aqui, combinamos três expressões boolianas para criar uma expressão booliana grande em uma única linha de código.
//Às vezes, isso é chamado de condição composta.
//Temos um conjunto de parênteses externo que combina três conjuntos de parênteses internos separados por dois caracteres de pipe.
//Os caracteres de pipe duplo || são o operador lógico OR
//que basicamente afirma que "a expressão à minha esquerda OU
//a expressão à minha direita precisa ser verdadeira para que
//toda a expressão booliana seja verdadeira".
//Se as duas expressões boolianas forem falsas
//a expressão booliana inteira será falsa.
//Usamos dois operadores lógicos OR para que possamos estender a avaliação para uma terceira expressão booliana.

//Primeiro, avaliamos (roll1 == roll2). Se for verdadeiro, a expressão inteira será verdadeira.
//Se for falso, avaliaremos (roll2 == roll3). Se for verdadeiro, a expressão inteira será verdadeira.
//Se for falso, avaliaremos (roll1 == roll3). Se for verdadeiro, a expressão inteira será verdadeira.
//Se for falso, a expressão inteira será falsa.

//Se a expressão booliana grande for verdadeira, executaremos o bloco de código abaixo.
//Desta vez, há duas linhas de código.
//A primeira linha de código imprime uma mensagem para o usuário.
//A segunda linha de código incrementa o valor de total em 2.

//Por fim, também alteramos a verificação para ver se o usuário venceu
//para usar o operador >=, o que se assemelha mais ao requisito que criamos quando começamos
//mas deve funcionar de forma idêntica ao que escrevemos anteriormente.

if (total >= 15)

    // é igual a

if (total > 14) ;

//-----------------------------------------------------------------------------------------------------------------------------------

//Jogo da microsoft - Etapa 4

//Em seguida, vamos implementar a regra:
//"Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado."

Random dice = new Random();

int rolar1 = dice.Next(1, 7);
int rolar2 = dice.Next(1, 7);
int rolar3 = dice.Next(1, 7);

int total = rolar1 + rolar2 + rolar3;

Console.WriteLine($"Valores dos dados: {rolar1} + {rolar2} + {rolar3} = {total}");

if ((rolar1 == rolar2) || (rolar2 == rolar3) || (rolar1 == rolar3))
{
    Console.WriteLine("Você rolou dados iguais! ganhou +2 pontos de bonus!!");
    total += 2;
}

if ((rolar1 == rolar2) && (rolar2 == rolar3))
{
    Console.WriteLine("Você rolou 3 dados iguais! ganhou 6 pontos de bonus!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("Você ganhou!");
}

if (total < 15)
{
    Console.WriteLine("Desculpe, você perdeu.");
}

//Os caracteres de E comercial duplos && são o operador lógico AND
//que basicamente afirma que "somente se duas as expressões forem verdadeira
//a expressão inteira será verdadeira"
//Nesse caso, se roll1 for igual a roll2, e roll2 for igual a roll3, por dedução
//roll1 deverá ser igual a roll3 e o usuário teve um resultado triplicado.

//Saída

//Valores dos dados: 5 + 5 + 5 = 15
//Você rolou dados iguais! ganhou +2 pontos de bonus!!
//Você rolou 3 dados iguais! ganhou 6 pontos de bonus!
//Você ganhou!
