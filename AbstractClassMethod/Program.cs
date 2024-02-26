using Tax;
using System.Collections.Generic;
using System.Globalization;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());


for(int i = 1; i <= n; i++ )
{
    Console.WriteLine($"Tax Payer #{i} data: ");

    Console.Write("Individual or company (i/c)? ");
    char question = char.Parse(Console.ReadLine());

    if (question == 'i' || question == 'I')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Anual Income: ");
        double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
        Console.Write("Health expenditures: ");
        double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Individual(name, anualIncome, healthexpenditures));
    }

    else
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Anual Income: ");
        double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        
        list.Add(new Company(name, anualIncome, employees));
    }

   
}

Console.WriteLine();
Console.WriteLine("Tax Paid: ");

foreach(TaxPayer taxpayer in list)
{
    Console.WriteLine("Name: " + taxpayer.Name + "Value($): " + taxpayer.TaxCallculation().ToString("F2", CultureInfo.InvariantCulture));
        
}

double total = 0;
foreach(TaxPayer taxpayer in list)
{
    total += taxpayer.TaxCallculation();
}

Console.WriteLine();
Console.WriteLine("Total Taxes: $ " + total.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadKey();