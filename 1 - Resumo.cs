//Todo este material é baseado nas documentações da Microsoft sobre como programar em C# e .NET

//Boa leitura


//Variaveis
//String são para caracteres e alfanumericos não calculaveis . operador adicional " " aspas duplas
//Char são para um unico caracter ou alfanumericos não calculaveis. operador adiicional ' ' aspas simples
//Int são para valores númericos calculaveis, não necessitando de operador adicional.
//Decimal são para valores númericos com casas adicionais, necessitando apenas de um m entre as casas. Ex 10.5m
//Boleano são valores lógicos, sendo verdadeiro ou falso, 1 ou 0.

//Utilização
//Supondo que crie um aplicativo que precise adicionar um número de telefone, o certo seria
//utilizar variavel String, sendo que não utilizamos números de telefone para calculos.
//Também serve para o bool, se precisar utilizar as palavras true ou false
//utilizariamos string, apenas utilizariamos o bool se tivessimos que trabalhar com estruturas de decisões

//char
Console.WriteLine('a');//Char sempre utiliza aspas simples e apenas 1 caracter
Console.WriteLine('1');//Podemos utilizar valores númericos não calculaveis

//String
Console.WriteLine("Como eu amo tudo isso!");
Console.WriteLine("123"); //string contendo valores numericos não calculaveis
Console.WriteLine("true");//string contendo valores bool sem estruturas de decisões
Console.WriteLine("false");//string contendo valores bool sem estruturas de decisões

//Int
Console.WriteLine(12345);

//Decimal
Console.WriteLine(10.3m); //Sempre utilizar m depois de adicionar valores depois do ponto.
Console.WriteLine(1000.00m)
Console.WriteLine(100.000m)

//Bool
Console.WriteLine(true); //não necessitam de operador adicional
Console.WriteLine(false); //sempre retornal no console sua condição.
