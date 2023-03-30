/*Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
A     senha     válida     é     o     número     1234. 
Devem     ser    impressas     as    seguintes     mensagens:
ACESSO    PERMITIDO    caso    a    senha    seja    válida.
ACESSO    NEGADO    caso    a    senha    seja    inválida.
*/

const int PASSWORD = 1234;
int informedPassword;

Console.Write($"Informe a senha: ");
informedPassword = int.Parse(Console.ReadLine());

if (informedPassword == PASSWORD) 
{
	Console.WriteLine($"ACESSO PERMITIDO");
}
else
{
	Console.WriteLine($"ACESSO NEGADO");
}