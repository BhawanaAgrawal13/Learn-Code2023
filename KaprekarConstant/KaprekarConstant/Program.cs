namespace KaprekarConstant;
internal class Program
{
    static void Main(string[] args)
    {
        string userInput;
        string choice;
        do
        {
            Console.WriteLine("Welcome\nEnter 1 to start testing numbers\nEnter 0 to quit: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    Console.WriteLine("Thank you");
                    break;

                case "1":
                    Console.Write("Enter any four digit sortedNumber: ");
                    userInput = Console.ReadLine();

                    if (IsExceptionToKaprekar(userInput) && userInput.Length == 4)
                    {
                        Console.WriteLine(CountingKaprekarsIteration(userInput));
                    }
                    else
                    {
                        Console.WriteLine("Number is invalid");
                    }
                    break;

                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }
        }
        while (choice != "0");

        Console.ReadLine();
    }

    static string OrderNumberByDescending(string number)
    {
        var sortedNumber = number.ToArray();

        for (int i = 0; i < sortedNumber.Length - 1; i++)
        {
            for (int j = 0; j < sortedNumber.Length - i - 1; j++)
            {
                if (sortedNumber[j] < sortedNumber[j + 1])
                {
                    char temp = sortedNumber[j];
                    sortedNumber[j] = sortedNumber[j + 1];
                    sortedNumber[j + 1] = temp;
                }
            }
        }

        return new string(sortedNumber);
    }

    static string OrderNumberByAscending(string number)
    {
        var sortedNumber = number.ToArray();

        for (int i = 0; i < sortedNumber.Length - 1; i++)
        {
            for (int j = 0; j < sortedNumber.Length - i - 1; j++)
            {
                if (sortedNumber[j] > sortedNumber[j + 1])
                {
                    char temp = sortedNumber[j];
                    sortedNumber[j] = sortedNumber[j + 1];
                    sortedNumber[j + 1] = temp;
                }
            }
        }

        return new string(sortedNumber);
    }

    static bool IsExceptionToKaprekar(string number)
    {
        for(int i=0; i< number.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < number.Length; j++)
            {
                if (number[j] == number[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if(count == 4)
            {
                return false;
            }
        }

        return true;
    }

    static int CountingKaprekarsIteration(string number)
    {
        int count = 0;

        while (number != "6174")
        {
            int largerNumber = Convert.ToInt32(OrderNumberByDescending(number));
            int smallerNumber = Convert.ToInt32(OrderNumberByAscending(number));

            number = (largerNumber - smallerNumber).ToString();

            if (number.Length < 4)
            {
                number = new string('0', 4 - number.Length) + number;
            }

            Console.WriteLine(largerNumber + " - " + smallerNumber + " = " + number);

            count++;
        }

        return count;
    }
}