namespace ConsoleApp1
{
    public class Calculator
    {
        //instance variables
        private int prize = 0;
        private int payment = 0;

        //getters and setters
        public int GetPrize()
        {
            return prize;
        }
        public void SetPrize(int value)
        {
            if (value >= 0)
                prize = value;
        }
        public int GetPayment()
        {
            return payment;
        }
        public void SetPayment(int value)
        {
            if (value >= 0)
                payment = value;
        }

        //calculate change
        public void CalculateChange()
        {
            int changeTotal = payment - prize;
            int changeCounter = changeTotal;
            Console.WriteLine($"Your change: {changeTotal}");

            int fiveHundredCounter = 0;
            int twoHundredCounter = 0;
            int oneHundredCounter = 0;
            int fiftyCounter = 0;
            int twentyCounter = 0;
            int tenCounter = 0;
            int fiveCounter = 0;
            int oneCounter = 0;

            while (changeTotal > 0)
            {
                if (changeTotal >= 500)
                {
                    while (changeTotal >= 500)
                    {
                        changeTotal -= 500;
                        fiveHundredCounter++;
                    }
                }
                else if (changeTotal >= 200)
                {
                    while (changeTotal >= 200)
                    {
                        changeTotal -= 200;
                        twoHundredCounter++;
                    }
                }
                else if (changeTotal >= 100)
                {
                    while (changeTotal >= 100)
                    {
                        changeTotal -= 100;
                        oneHundredCounter++;
                    }
                }
                else if (changeTotal >= 50)
                {
                    while (changeTotal >= 50)
                    {
                        changeTotal -= 50;
                        fiftyCounter++;
                    }
                }
                else if (changeTotal >= 20)
                {
                    while (changeTotal >= 20)
                    {
                        changeTotal -= 20;
                        twentyCounter++;
                    }
                }
                else if (changeTotal >= 10)
                {
                    while (changeTotal >= 10)
                    {
                        changeTotal -= 10;
                        tenCounter++;
                    }
                }
                else if (changeTotal >= 5)
                {
                    while (changeTotal >= 5)
                    {
                        changeTotal -= 5;
                        fiveCounter++;
                    }
                }
                else if (changeTotal >= 1)
                {
                    while (changeTotal >= 1)
                    {
                        changeTotal -= 1;
                        oneCounter++;
                    }
                }

            };

            if (fiveHundredCounter != 0)
                Console.WriteLine($"{fiveHundredCounter} 500-bill{MoneyTypePlural(fiveHundredCounter)}");
            if (twoHundredCounter != 0)
                Console.WriteLine($"{twoHundredCounter} 200-bill{MoneyTypePlural(twoHundredCounter)}");
            if (oneHundredCounter != 0)
                Console.WriteLine($"{oneHundredCounter} 100-bill{MoneyTypePlural(oneHundredCounter)}");
            if (fiftyCounter != 0)
                Console.WriteLine($"{fiftyCounter} 50-bill{MoneyTypePlural(fiftyCounter)}");
            if (twentyCounter != 0)
                Console.WriteLine($"{twentyCounter} 20-bill{MoneyTypePlural(twentyCounter)}");
            if (tenCounter != 0)
                Console.WriteLine($"{tenCounter} 10-coin{MoneyTypePlural(tenCounter)}");
            if (fiveCounter != 0)
                Console.WriteLine($"{fiveCounter} 5-coin{MoneyTypePlural(fiveCounter)}");
            if (oneCounter != 0)
                Console.WriteLine($"{oneCounter} 1-coin{MoneyTypePlural(oneCounter)}");
        }
        
        //adjusts bill and coin to plural, bills and coins, if the amount calls for it
        private string MoneyTypePlural(int value)
        {
            string pluralType = "";

            if (value > 1)
            {
                pluralType += "s";
            }

            return pluralType;
        }
    }
}
