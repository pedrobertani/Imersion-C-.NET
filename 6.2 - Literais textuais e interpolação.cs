//Literais textuais e interpolação

//Suponha que você precise usar um literal textual em seu modelo.
//Você pode usar o símbolo @ de prefixo literal textual e o símbolo $ de interpolação de cadeia de caracteres juntos.

string projectName = "Apostila-C#";
Console.WriteLine($@"c:\C#\{projectName}\modulo 6");

//Saída
//c:\C#\Apostila-C#\modulo 6