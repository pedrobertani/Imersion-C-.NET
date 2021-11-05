/*
Operador += e ++

Esse conceito é muito utilizado em algumas programações, principamente quando trabalhamos com loop.
O operador += adiciona e atribui um valor a direita do operador ao valor a esquerda do operador.
Um pouco confuso, mas vamos mostrar na pratica.
*/

int value = 0; //Aqui decicimos variavel valor do tipo int
value = value + 5; //Aqui dizemos que valor passou a ser igual a valor + 5 ou seja (0 + 5)
value += 5; //Aqui valor (5), adicionamos valor + 5, ou seja, quando eu coloco += seria o mesmo que valor = valor + 5;

Console.WriteLine(value);

/*
Saída
10 
*/

/*
É como se fosse uma equação: valor = 0, > valor = 0 + 5, > valor = 5 + 5, > valor = 10;


O operador ++ adiciona em sua variavel 1 a mais.
Ou seja, 3 ++ é igual a 3 + 1.
Vamos para pratica:
*/

int value = 0;
value = value + 3;
value++; //Quando utilizamos -- ele adiciona o valor 1 da variavel 

Console.WriteLine(value);

/*
Saída
4
*/

/*
Operador -= e --

O operador -= subtrai e atribui um valor menor a direita do operador ao valor a esquerda do operador.
*/

int value = 10; //Aqui decicimos variavel valor do tipo int
value -= 5; //Aqui valor (10), subtraimos de 5, ou seja, quando eu coloco -= seria o mesmo que valor = valor - 5;

Console.WriteLine(value);

/*
Saída
5
*/


int value = 10; //Aqui decicimos variavel valor do tipo int
value--; //Quando utilizamos -- ele subtrai o valor 1 da variavel 
Console.WriteLine(value)

/*
Saída
9
*/


//Utilizando os dois operadores

int value = 1;

value = value + 1;
Console.WriteLine("Primeiro imcremento: " + value);

value += 1;
Console.WriteLine("Segundo imcremento: " + value);

value++;
Console.WriteLine("Terceiro incremento: " + value);

value = value - 1;
Console.WriteLine("Primeiro decremento: " + value);

value = value -= 1;
Console.WriteLine("Segundo decremento: " + value);

value--;
Console.WriteLine("Terceiro drecremento: " + value);

/*
Saída
Primeiro imcremento: 2
Segundo imcremento: 3
Terceiro incremento: 4
Primeiro decremento: 3
Segundo decremento: 2
Terceiro drecremento: 1
*/