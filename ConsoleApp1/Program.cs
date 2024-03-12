namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new();

            //Read user input and calculate change
            ReadInput(calculator);
            calculator.CalculateChange();
        }

        /// <summary>
        /// Reads input through ReadPrize and ReadPayment,
        /// then makes sure that the payment is sufficient for the prize
        /// </summary>
        static void ReadInput(Calculator calculator)
        {
            bool correctInput;

            ReadPrize(calculator);
            ReadPayment(calculator);

            do
            {
                if (calculator.GetPrize() <= calculator.GetPayment())
                {
                    correctInput = true;
                }
                else
                {
                    correctInput = false;

                    Console.WriteLine();
                    Console.WriteLine("I'm sorry, Your payment is insufficient. Please try again.");
                    Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine($"THE PRIZE: {calculator.GetPrize()}");
                    ReadPayment(calculator);
                }

            } while (correctInput == false);
        }

        /// <summary>
        /// Reads user-input prize, and makes sure its a valid number,
        /// before setting the Calculator instance variable
        /// </summary>
        static void ReadPrize(Calculator calculator)
        {
            string readResult;
            bool validInput;

            Console.WriteLine("Enter the prize of your wares:");

            do
            {
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    int prize = Convert.ToInt32(readResult);
                    calculator.SetPrize(prize);
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("I'm sorry, please try again. Enter a proper number as prize.");
                }
            } while (validInput == false);
        }

        /// <summary>
        /// Reads user-input payment, and makes sure its a valid number,
        /// before setting the Calculator instance variable
        /// </summary>
        static void ReadPayment(Calculator calculator)
        {
            string readResult;
            bool validInput;

            Console.WriteLine("And enter the amount you will pay:");

            do
            {
                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    int payment = Convert.ToInt32(readResult);
                    calculator.SetPayment(payment);
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("I'm sorry, please try again. Enter a proper number as prize.");
                }
            } while (validInput == false);
        }
    }
}
