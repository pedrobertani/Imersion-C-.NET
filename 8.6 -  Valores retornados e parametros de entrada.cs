//Alguns métodos são criados para não aceitarem parâmetro de entradas.
//Esses métodos não precisam de entradas adicionais para concluirem suas tarefas.
//Já, outros, aceitam mais do que um parâmetro de entrada, sendo assim um tipo de congiguração de como ele deve ser executado.
//Ao chamar o método separe cada parâmetro de entrada com um símbolo " , "
//No exemplo a seguir, iremos configurar o método Next() com parâmetros onde seram definidos os limites do mesmo.

int roll = dice.Next(1, 7);

//Na proxima linha os parâmetros que o WriteLine() recebe para procesguir no console.

Console.WriteLine(roll);

//Outros modos que podemos utilizar o WriteLine()

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

//Saída

//7
//
//seven

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

//Saída

First roll: 1876892383
Second roll: 28
Third roll: 53

//Primeiro roll

//No primeiro roll, não definimos valores de parâmetros, inicio e fim.
//Então, ele utiliza o padrão de int, que variam de 0 a 2,147,483,647

//Segundo roll

//No segundo, foi especificado que o máximo é 101.
//Sendo assim, int que é uma variavel que inicia em 0, podemos ter um número aleatório de 0 a 101.

//Terceiro roll

//No terceiro, foi especificado o valor de 50 a 101, sendo assim ele varia entre esses valores.
//Lembrando que este método é um método de números aleatórios.

//Aqui, descrevemos:

//O que um método pode fazer
//Se ele tem versões sobrecarregadas
//Quais tipos de dados são aceitos como parâmetros de entrada
//Se ele tem um valor de retorno e, em caso afirmativo, o que ele retorna.