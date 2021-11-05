/*
Obtendo tamanho da matriz

Caso tenhamos que dar manutenção em uma programação já criada, poderiamos precisar descobrir o tamanho de uma matriz.
Para descobrirmos sem ter que vasculhar as linhas de código, para isso podemos utilizar a propriedade Length
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Terceiro: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "D000";

Console.WriteLine("\n Atualização \n");

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]} \n");

Console.WriteLine($"Temos {fraudulentOrderIDs.Length} ordens fraudadas no processo.");

/*
 Saída

Primeiro: A123
Segundo: B456
Terceiro: C789

 Atualização 

Primeiro: D000
Temos 3 ordens fraudadas no processo.
*/