using System;

namespace kookie
{
    class Program
    {
        static void Main(string[] args)
        {

            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.printbalance();

            mortgage.WaitOneYear();
            mortgage.printbalance();

            // Wait 20 years
            int years = 0;
            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }

            mortgage.printbalance();

         Console.ReadKey();
        }


    }

    class Debt
    {
        private double initialBalance;
        private double initialInterestRate;
        public Debt(double initialBalance, double initialInterestRate)
        {
            this.initialBalance = initialBalance;
            this.initialInterestRate = initialInterestRate;

        }
        public void printbalance()
        {
            System.Console.WriteLine(initialBalance);
        }
        public double WaitOneYear()
        {
            initialBalance = initialBalance * initialInterestRate;
            return initialBalance;

        }

    }

}