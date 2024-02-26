namespace Tax
{
    class Company : TaxPayer
    {
        public int QuantityEmployees{get;set;}

        public Company(string name, double annualIncome, int quantityEmployees): base(name, annualIncome)
        {
            QuantityEmployees = quantityEmployees;
        }


        public override double TaxCallculation()
        {
            if(QuantityEmployees > 10)
            {
                return AnnualIncome * 14/100;
            }

            else
            {
                return AnnualIncome * 16/100;
            }
        }
    }
}