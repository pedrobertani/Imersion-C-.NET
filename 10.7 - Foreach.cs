/*
Foreach

Foreach é uma instrução que realiza loop em cada elemento da matriz.
*/

string[] names = {"Pedro", "Tiago", "João"};
foreach (string name in names)
{
    Console.WriteLine(name);
}

/*
Leitura do código: Temos, uma matriz, string, chamada nomes, contendo Pedro, Tiago e João.
Para cada (string nome em nomes).

Abaixo da palavra-chave foreach(para cada), o bloco de código({}) que contém Console.WriteLine(name); 
será executado uma vez para cada elemento da matriz names. 
Como o runtime do .NET executa um loop em cada elemento da matriz, 
o valor armazenado no elemento atual da matriz names será atribuído à variável temporária 
name para facilitar o acesso dentro do bloco de código.

Saída

Pedro
Tiago
João

 */



