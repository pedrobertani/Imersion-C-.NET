//Concatenar variavel e uma frase 

//Muitas linguagens de programação utilizam + para concatenação de variaveis e cadeias literais, o c# é uma delas.

string firstName = "Pedro";
string message = "Olá " + firstName;
Console.WriteLine(message);

//Saída
//Olá Pedro

//ou

string firstName = "Pedro";
string greeting = "Olá";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

//Saída
//Olá Pedro!

//porem devemos evitar o uso indevivo de criações de variaveis, então..

string firstName = "Pedro";
string greeting = "Olá";
Console.WriteLine(greeting + " " + firstName + "!");

//Saída
//Olá Pedro!