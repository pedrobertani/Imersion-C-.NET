/*
Diferentes tipos de operações

Agora vamos fazer os tipos básicos de operações matemáticas por código.
*/

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Tipos diferentes de contas com números 7 e 5.");
Console.WriteLine("Soma: 7 + 5 = " + sum);
Console.WriteLine("Subtração: 7 - 5 = " + difference);
Console.WriteLine("Mutiplicação: 7 * 5 = " + product);
Console.WriteLine("Divisão: 7 / 5 = " + quotient);

/*
Saída
Tipos diferentes de contas com números 7 e 5.
Soma: 7 + 5 = 12
Subtração: 7 - 5 = 2
Mutiplicação: 7 * 5 = 35
Divisão: 7 / 5 = 1
*/

/*
Porém, percebemos que, a divisão não está totalmente correta..
Isso pelo fato que a divisão de 7 / 5 é um número com ponto flutuante, ou casa.
Então, quando mexemos com números com casa, usamos tipo de variavel decimal
*/

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
decimal quotient = 7.0m / 5;

Console.WriteLine("Tipos diferentes de contas com números 7 e 5.");
Console.WriteLine("Soma: 7 + 5 = " + sum);
Console.WriteLine("Subtração: 7 - 5 = " + difference);
Console.WriteLine("Mutiplicação: 7 * 5 = " + product);
Console.WriteLine("Divisão: 7.0m / 5 = " + quotient);

/*
Saída
Tipos diferentes de contas com números 7 e 5.
Soma: 7 + 5 = 12
Subtração: 7 - 5 = 2
Mutiplicação: 7 * 5 = 35
Divisão: 7.0m / 5 = 1.4
*/


//Outro modos de fazer essa divisão (CORRETOS)

decimal decimalQuotient1 = 7 / 5.0m;
decimal decimalQuotient2 = 7.0m / 5.0m;

Console.WriteLine(decimalQuotient1);
Console.WriteLine(decimalQuotient2);

/*
Saída

1.4
1.4
*/

//Modos incorretos 

int decimalQuotient = 7 / 5.0m;
int decimalQuotient = 7.0m / 5;
int decimalQuotient = 7.0m / 5.0m;
decimal decimalQuotient = 7 / 5;


//Mas também podemos transformar as variaveis do tipo int para decimal

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

/*
Saída

1.4
*/


//Temos também como escrever códigos para que sobre o resto das divisões

Console.WriteLine("Resto de divisão de 200 / 5 : " + (800 % 5));
Console.WriteLine("Resto de divisão de 7 / 5: " + (6 % 5));

/*
Saída
Resto de divisão de 200 / 5 : 0
Resto de divisão de 7 / 5: 1
*/

