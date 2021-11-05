/*
 Mistura de dados
E se tentarmos utilizar uma adição entre string e int?
Neste caso o C# entende que queremos concatecar as duas variaveis, string e int
*/

string firstName = "Pedro ";
int years = 27;
Console.WriteLine(firstName + "tem " + years + " anos");

/*
Saída
Pedro tem 27 anos
*/


//E se tentarmos fazer uma adição em meio a um código que tenha string?

string firstName = "Pedro";
int years = 20;
Console.WriteLine(firstName + " tem " + years + 7 + " anos.");

/*
Saída
Pedro tem 207 anos.
*/

/*
Em vez de tratar a variavel e o número como uma soma, ele trata como concatenação, pelo fato de conter strings no código.
Mas existe uma maneira de fazer isso, utilizando o parênteses.
*/

string firstName = "Pedro";
int years = 20;
Console.WriteLine(firstName + " tem " + (years + 7) + " anos.");

/*
Saída
Pedro tem 27 anos.
*/

/*
Nesse caso o simbolo parênteses () também é um operador sobrecarregado.
E como na matemática, o C# entende que o fechamento de parênteses com duas variaveis int e um simbolo de operação, neste caso +
É uma operação matemática e precisa ser resolvido antes de dar a saida do código.
*/
