/*
* Using these 15 integers: 9, 2, 5, 4, 12, 7, 8, 11, 9, 3, 7, 4, 12, 5, 4
* Should produced the following results:
* "The mean is: 6.8"
* "The standard deviation is: 3.16649122321011"
*/

using System;
class ParallelArrays
{

    static void Main()
    {

        double[] numbers = new double[15];
        double[] arrOfMeans = new double[15];
        double[] arrOfSquares = new double[15];

        Console.WriteLine("Welcome to the Parallel Arrays Program.\n");

        for (int count = 0; count < numbers.Length; ++count)
        {
            Console.Write(count + ". Please enter an integer: ");
            numbers[count] = double.Parse(Console.ReadLine());
        }

        for (int count = 0; count < 5; ++count)
        {
            Console.WriteLine(count + ". The integer is : " + numbers[count]);
        }
        Console.WriteLine("The total amount of numbers in the array is: " + numbers.Length);

        double sum = 0;
        double mean;
        Array.ForEach(numbers, i => sum += i);
        Console.WriteLine("The sum of the array is: " + sum);

        mean = sum / numbers.Length;
        Console.WriteLine("The mean is: " + mean);

        for (int count = 0; count < numbers.Length; ++count)
        {
            arrOfMeans[count] = numbers[count] - mean;
        }

        for (int count = 0; count < arrOfMeans.Length; ++count)
        {
            arrOfSquares[count] = arrOfMeans[count] * arrOfMeans[count];
        }

        double total = 0;
        double avg;
        Array.ForEach(arrOfSquares, i => total += i);
        avg = total / arrOfSquares.Length;

        Console.WriteLine("The standard deviation is: " + Math.Sqrt(avg));
        Console.WriteLine("\nThank you for using the Parallel Arrays Program.  ");
        Console.WriteLine("See you again soon!");
    }
}


