//Como é possível determinar se você precisa criar uma instância de uma classe ante de chamar seus métodos?

//Uma maneira de aprender a chamar o método é consultar a documentação.
//Você encontrará exemplos que mostram se o método deve ser chamado da instância do objeto ou diretamente da classe.

//Como alternativa, é possível tentar acessar o método diretamente da própria classe.
//O pior que pode acontecer é você receber um erro de compilação.

//Se você digitar a linha de código a seguir no Editor do .NET:

int result = Random.Next();

//Saída
//(1,14): error CS0120: An object reference is required for the non-static field, method, or property 'Random.Next()'
