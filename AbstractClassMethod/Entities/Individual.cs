namespace Tax
{
    class Individual : TaxPayer
    {
        public double HealthSpending{get;set;}

        public Individual(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxCallculation()
        {
            if(AnnualIncome < 20000 && HealthSpending == 0)
            {

                return AnnualIncome * 15/100;
               
            }


            else if(AnnualIncome < 20000 && HealthSpending > 0 )
            {
                return AnnualIncome * 15/100 - HealthSpending * 50/100;
            }


            else if(AnnualIncome >= 20000 && HealthSpending == 0)
            {
                return AnnualIncome * 25/100;
            }


            else
            {
                return AnnualIncome * 25/100 - HealthSpending * 50/100;
            }
            
        }

    }
}