/*
Método com Estado ou métodos de instância

Na computação, o estado descreve a condição do ambiente de execução especifico momento no tempo.
Conforme seu código executa linhas por linhas, os valores são armazenados em variaveis.
A qualquer momento durante a execução, o estado atual do aplicativo é a coleção de todos os valores armazenados na memória.
Ou seja, dependem de valores armazenados em memória pelas linhas de códigos anteriores que já foram executadas.
Ou modificam o estado do aplicativo atualizando os valores armazenados na memória com novos valores.
Os métodos de instância controlam seu estado em campos, que são váriaveis deficinas na classe.
Cada nova instância da classe tem sua própria cópia desses campos nos quais estado é armazenado.
Uma única classe pode dar supote a métodos com e sem estados.
Porem, quando você precisar chamar métodos com estado, deverá criar uma instância da classe para que o método possa acessar o estado.

Métodos sem estado ou métodos estáticos

Alguns métodos não dependem do estado atual do aplicativo para funcionarem corretamente.
Os métodos sem estados são implementados para funcionar sem referenciar ou alterar valores já armazenados na memória.
Também conhecidos como métodos estáticos.

Por exemplo, o método Console.WriteLine() não depende de nenhum valor armazenado na memória.
Ele executa sua função sem afetar o estado do aplicativo.
*/




 