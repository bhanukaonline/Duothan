namespace ArmstrongNumbers
{
    using System;

    class ArmstrongNumbers
    {
        static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;
            int numberOfDigits = 0;

            while (number > 0)
            {
                number /= 10;
                numberOfDigits++;
            }

            number = originalNumber;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                number /= 10;
            }

            return sum == originalNumber;
        }

        static void Main(string[] args)
        {
            Console.Write("Armstrong Numbers (0 to 100,000): ");

            bool firstNumber = true;
            for (int number = 0; number < 100001; number++)
            {
                if (IsArmstrong(number))
                {
                    if (firstNumber)
                    {
                        firstNumber = false;
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                    Console.Write(number);
                }
            }
            Console.WriteLine();
        }
    }
}
