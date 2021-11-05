/*
Criando e inicilalizando uma matriz int.

Agora, iremos criar uma matriz int para o desafio da microsoft.

Desafio:

Imagine que você trabalha para uma fábrica e precisa fazer um inventário do depósito para determinar
o número atual de produtos finais que estão prontos para o envio. Além do número total de produtos finais, 
você também pode querer imprimir uma contagem e o total atual de cada compartimento individual do depósito em que
os produtos finais são armazenados. Imprimir esse total atual criaria uma trilha de auditoria para verificar novamente 
o trabalho e identificar reduções.

Começando:

Criar uma matriz de int que armazenará o número de produtos finais em cada compartimento.
*/ 

int[] inventory = { 200, 450, 700, 175, 250 }; //Aqui chamamos uma matriz int, onde o nome é inventory e nela contera tais numeros.

/*
Em seguida, adicione uma instrução foreach que itera em cada elemento da matriz inventory, 
atribuindo temporariamente o valor do elemento atual à variável items.
*/

int[] inventory = { 200, 450, 700, 175, 250 };
foreach(int items in inventory) //aqui declaramos que para cada item no inventário faremos:{}
{

}

/*
Adicionar uma variável para somar o valor de cada elemento na matriz.
Defina uma nova variável que representa a soma de todos os produtos finais no depósito.
Não se esqueça de adicioná-la fora da instrução foreach.
*/

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
	sum += items; //Enquanto ouver o loop, a variavel sum vai somar todos os numeros da matriz.
}

/*
sum += intems; = 0 + 200 = 200
sum += items; 200 + 450 = 650
e assim por diante.
Agora iremos chamar sum no console para que ela mostre qual foi o valor final dentro dos valores somados na matriz.
Ou seja, foreach para o loop apenas quando acabar as variaveis da matriz.
*/

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
	sum += items;
}

Console.WriteLine($"Nós temos, {sum} intens no inventário.");

/*
Saída

Nós temos, 1775 intens no inventário.

Agora iremos criar uma variavel para, armazenar o número do compartimento e exibir o total atual.

Para atender ao requisito final, é preciso criar uma variável para conter a alteração atual da instrução foreach. 
Desse modo, é possível exibir o compartimento e a quantidade de itens finalizados dele junto com o total atual
de todos os itens dos compartimentos contados até o momento.

Acima da instrução foreach, declare e inicialize uma nova variável do tipo int para armazenar o número atual do compartimento
cujo inventário está sendo processado.

Dentro do bloco de código foreach,
incremente o compartimento cada vez que o bloco de código for executado, ele adicionara um na variavel.
O operador ++ incrementa o valor da variável em 1. É um atalho para escrever bin = bin + 1.
Por fim, dentro do foreach, exiba o compartimento,
a contagem de produtos finais e o total atual de produtos finais em uma mensagem bem formatada.


*/

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
	sum += items;
	bin++;
	Console.WriteLine($"Inventário {bin} = {items} itens ( Total executado: {sum})");
}

Console.WriteLine($"\n Nós temos, {sum} itens no inventário.");

/*
Saída
Inventário 1 = 200 itens ( Total executado: 200)
Inventário 2 = 450 itens(Total executado: 650)
Inventário 3 = 700 itens(Total executado: 1350)
Inventário 4 = 175 itens(Total executado: 1525)
Inventário 5 = 250 itens(Total executado: 1775)

 Nós temos, 1775 itens no inventário.
*/