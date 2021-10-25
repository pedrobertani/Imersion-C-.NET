//Adição simples e conversão de dados implicita

//Você pode executar operações matemáticas, como de adição, em números.
//A concatenação de cadeias de caracteres e a adição usam o símbolo de adição +.
//Isso é chamado de sobrecarregar um operador e o compilador infere o uso adequado com base nos tipos de dados em que opera.
//Quando puder, o compilador de C# converterá implicitamente um int em um string
//se for óbvio que o desenvolvedor está tentando concatenar
//a representação de cadeia de caracteres de um número para fins de apresentação.
//Use parênteses para definir a ordem das operações
//a fim de informar explicitamente ao compilador que desejamos executar determinadas operações antes de outras.

//Operadores matemáticos 

// + é o operador de adição
// - é o operador de subtração
// * é o operador de multiplicação
// / é o operador de divisão

//Ordem de operações

//podemos usar os símbolos () como os operadores de ordem das operações.
//Porém esta não é a única forma da ordem das operações ser determinada.

//PEMDAS

//PEMDAS é um acrônimo que ajuda os alunos a se lembrar da ordem em que várias operações são executadas.
//A ordem é:
//1. P arêntese (o que estiver dentro do parêntese é executado primeiro)
//2. E xponentes
//3. M ultiplicação e D ivisão (da esquerda para a direita)
//4. A dição e S ubtração (da esquerda para a direita)

//C# segue a mesma ordem que o acrônimo PEMDAS, exceto pelos exponentes.
//Embora não haja um operador com exponente em C#, você pode usar o método System.Math.Pow()
//que está disponível na Biblioteca de Classes .NET. 

//Operadores como +=, -=, *=, ++ e -- são conhecidos como operadores de atribuição composta
//porque compõem uma operação além de atribuir o resultado à variável.
//O operador += é chamado especificamente de operador de atribuição de adição

//Use operadores de atribuição compostos como +=, -=, *=, ++ e -- para executar uma operação matemática
//como incremento ou decremento e, em seguida, atribua o resultado à variável original.
//Operadores de incremento e decremento são executados de forma diferente quando o operador está antes ou depois do operando.