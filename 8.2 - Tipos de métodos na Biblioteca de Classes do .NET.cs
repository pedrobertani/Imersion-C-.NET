//Chamar diferentes tipos de métodos na Biblioteca de Classes do .NET

//Agora trabalharemos com uma classe que faz números aleatórios.

Random dice = new Random(); 
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//Saida
//números aleatórios de 1 a 6 .

//A primeira linha do código cria uma instancia de classe System.Random na Biblioteca do classe .NET
//E armazena a referencia ao novo objeto em uma variavel denominada dice:

Radom dice = new Random();

//A segunda linha chama o metodo Next() do objeto dice
//Que passa dois parametros o valor mínimo e o valor máximo do número aleatório:

int roll = dice.Next(1, 7);

//O metodo Next() retorna o valor, que adicionamos na variavel chamada roll
//a terceira linha chama o metodo WriteLine() que imprimi o valor adicionado na variavel roll:

Console.WriteLine(roll);


//Neste exemplo, estamos chamando um método da classe Random e da classe Console.
//No entanto, a maneira como estamos chamando esses métodos é diferente.
//O motivo pelo qual eles foram chamados usando uma técnica diferente é porque alguns métodos são com estado e outros, sem estado.