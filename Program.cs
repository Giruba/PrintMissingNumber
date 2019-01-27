using System;

namespace FindMissingNumberInContigousRepetitionOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Missing Number in Consecutively repeated numbers!");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Enter the string sequence please!");
            try
            {
                String input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("The entered string is empty!");
                }
                else {
                    int missedNumber = GetMissingNumber(input);
                    if (missedNumber != -1)
                    {
                        Console.WriteLine("The number missed to be present " +
                            "consectively thrice is " + missedNumber);
                    }
                    else {
                        Console.WriteLine("No number is missing!");
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            Console.ReadLine();
        }

        private static int GetMissingNumber(String input) {
            int result = -1;

            input = input.Trim();
            char[] charArray = input.ToCharArray();
            int length = input.Length;
            for (int i = 0; i < length; i++) {
                try
                {
                    int number = (int)Char.GetNumericValue(charArray[i]);
                    int count = 1;
                    
                    for (int j = i+1; i+1 < length && i+3 < length && j < i+3; j++) {
                        try
                        {
                            if (number != (int)Char.GetNumericValue(charArray[j]))
                            {
                                return number;
                            }
                            count++;
                        }
                        catch (Exception exception) {
                            Console.WriteLine("GetMissingNumber: Exception occured " +
                                "during consecutive number checking." +
                                "Thrown exception is"+exception.Message);
                        }
                    }
                    if (count != 3) {
                        return number;
                    }
                    i += 2;

                } catch (Exception exception) {
                    Console.WriteLine("GetMissingNumber: Thrown exception is "+exception.Message);
                }
            }

            return result;
        }
    }
}
