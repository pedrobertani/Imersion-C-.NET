//Interpolação de cadeia de caracteres

//A interpolação combina vários valores em uma única cadeia de caracteres
//Uma interpolação é uma váriavel cercada por símbolo de chave {}
//Para chamarmos variaveis em {} utilizaremos o prefixado $

string firstName = "Pedro";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

//Saída
//Hello Pedro!

string firstName = "Pedro";
string greeting = "Olá";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

//Saída
//Hello Pedro!

//Mas para um código de boas praticas, limpo e poucas váriaveis 

string firstName = "Pedro";
string greeting = "Olá";
Console.WriteLine($"{greeting} {firstName}!");

//Saída
//Hello Pedro!
