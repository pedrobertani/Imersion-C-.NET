/*
Inicializar uma matriz


Assim como nós podemos inicializar uma variável no momento em que a declaramos, 
é possível inicializar uma nova matriz no momento da declaração usando uma sintaxe especial, incluindo chaves.
*/

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Terceiro: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "D000";

Console.WriteLine("\n Atualização \n");

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");

