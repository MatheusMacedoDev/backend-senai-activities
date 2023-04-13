using System.Globalization;

static decimal calculateTaxIncome(decimal income) 
{
	decimal taxIncome = 0;
	
	if (income > 6000) 
	{
		taxIncome = income * 0.35m;
	} else if (income >= 3501) 
	{
		taxIncome = income * 0.25m;
	} else if (income >= 1501) 
	{
		taxIncome = income * 0.2m;
	}
	
	return taxIncome;
}

Console.Write($"Type the income: ");
decimal income = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Your income tax is {calculateTaxIncome(income).ToString("C", new CultureInfo("pt-BR"))}");
