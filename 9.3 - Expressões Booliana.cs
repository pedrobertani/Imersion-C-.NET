//Expressão booliana

//São códigos que retornam valores boleanos, ou seja, códigos de verificação: verdadeiro ou falso, true or false.
//Por exemplo, este é um exemplo de código simples que usa o método string.Contains()
//para avaliar se uma cadeia de caracteres contém outra.

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

//Saída
//True
//What does the fox say?

//Como retorna um valor de true ou false, message.Contains("fox")
//se qualifica como uma expressão booliana e pode ser usado em uma instrução if.

//Outras expressões boolianas simples podem ser criadas usando operadores para comparar dois valores. Os operadores incluem:

//==, o "operador igual" para testar a igualdade
//>, o "operador maior que", para testar se o valor à esquerda é maior que o valor à direita
//<, o "operador menor que", para testar se o valor à esquerda é menor que o valor à direita
//>=, o "operador maior que ou igual a"
//<=, o "operador menor que ou igual a"
//e assim por diante
