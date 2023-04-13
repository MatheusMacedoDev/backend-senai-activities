static decimal somar(decimal n1, decimal n2) 
{
	return n1 + n2;
}

static decimal subtrair(decimal n1, decimal n2) 
{
	return n1 - n2;
}

static decimal multiplicar(decimal n1, decimal n2) 
{
	return n1 * n2;
}

static decimal dividir(decimal n1, decimal n2) 
{
	return n1 / n2;
}

int n1 = 3;
int n2 = 2;

Console.WriteLine($"{n1} * {n2} = {multiplicar(n1, n2)}");
