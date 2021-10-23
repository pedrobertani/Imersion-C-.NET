//Interpola��o de cadeia de caracteres

//A interpola��o combina v�rios valores em uma �nica cadeia de caracteres
//Uma interpola��o � uma v�riavel cercada por s�mbolo de chave {}
//Para chamarmos variaveis em {} utilizaremos o prefixado $

string firstName = "Pedro";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

//Sa�da
//Hello Pedro!

string firstName = "Pedro";
string greeting = "Ol�";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

//Sa�da
//Hello Pedro!

//Mas para um c�digo de boas praticas, limpo e poucas v�riaveis 

string firstName = "Pedro";
string greeting = "Ol�";
Console.WriteLine($"{greeting} {firstName}!");

//Sa�da
//Hello Pedro!
