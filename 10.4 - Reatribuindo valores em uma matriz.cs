/*
Reatribuindo valores em uma matriz

Os elementos de uma matriz são como qualquer outra variável, podendo atribuir, recuperar e modificar seus valores.
Aqui vamos alterar o valor da primeira variavel.
*/

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Terceiro: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "D000";

Console.WriteLine("\n Alteração \n");

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");

/*
Saída

Primeiro: A123
Segundo: B456
Terceiro: C789

Alteração

Primeiro: D000
*/
