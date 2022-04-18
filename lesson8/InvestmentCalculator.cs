using System;
class InvestmentCalculator
{
    static double getFinalBalance(double principal, double interest, int freq, int years)
    {
        double result;
        result = principal * Math.Pow((1 + interest / freq), (freq * years));
        return result;
    }

    static void displayResult(double initialAmount, double interestRate, int frequency, int years, double finalBalance)
    {
        Console.WriteLine("Principal amount invested: " + initialAmount);
        Console.WriteLine("Interest rate: " + interestRate);
        Console.WriteLine("Compounding frequency: " + frequency);
        Console.WriteLine("Number of years: " + years);
        Console.WriteLine("Ending balance: " + finalBalance);
    }

    static void Main()
    {
        // Declarations and initializations
        double initialAmount = 5000.00;
        double interestRate = 0.03;
        double finalBalance;
        int frequency = 4;
        int years = 1;

        finalBalance = getFinalBalance(initialAmount, interestRate, frequency, years);
        displayResult(initialAmount, interestRate, frequency, years, finalBalance);
        Console.WriteLine("End of program.");

    }
}
