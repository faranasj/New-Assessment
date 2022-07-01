using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
        Console.Write("Enter minimum number: ");
        int minNumber = Int32.Parse(Console.ReadLine());
        Console.Write("Enter maximum number: ");
        int maxNumber = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"The numbers devisable by 5 without remainder from {minNumber} to {maxNumber} are: ");
        int count = 0;
        for (int i = minNumber; i <= maxNumber; i++)
        {
            if (i % 5 == 0)
            {

                Console.WriteLine(i);
                count++;
            }
        }
            Console.WriteLine();

            // 2.
            Console.WriteLine();
            int sequence1 = 0;
            int sequence2 = 1;
            int fibonacci = 100;

            for(int i= 2; i < fibonacci; ++i)
            {
                int sequence3 = sequence1 + sequence2;
                Console.Write($"{sequence3},");
                sequence1 = sequence2;
                sequence2 = sequence3;
            }
            Console.WriteLine();

            // 3.
            Console.WriteLine();
            Console.WriteLine("Kindly enter 5 numbers: ");
            int firstNum = Int32.Parse(Console.ReadLine());
            int secondNum = Int32.Parse(Console.ReadLine());
            int thirdNum = Int32.Parse(Console.ReadLine());
            int fourthNum = Int32.Parse(Console.ReadLine());
            int fifthNum = Int32.Parse(Console.ReadLine());

            if((firstNum >= secondNum) && (firstNum >= thirdNum) && (firstNum >= fourthNum) && (firstNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {firstNum}");
            }
            else if((secondNum >= firstNum) && (secondNum >= thirdNum) && (secondNum >= fourthNum) && (secondNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {secondNum}");
            }
            else if((thirdNum >= firstNum) && (thirdNum >= secondNum) && (thirdNum >= fourthNum) && (thirdNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {thirdNum}");
            }
            else if((fourthNum >= firstNum) && (fourthNum >= secondNum) && (fourthNum >= thirdNum) && (fourthNum >= fifthNum))
            {
                Console.WriteLine($"The greatest number is: {fourthNum}");
            }
            else if((fifthNum >= firstNum) && (fifthNum >= secondNum) && (fifthNum >= thirdNum) && (fifthNum >= fourthNum))
            {
                Console.WriteLine($"The greatest number is: {fifthNum}");
            }
            Console.WriteLine();

            // 4.
            Console.WriteLine();
            Console.WriteLine("Enter a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            int c = Int32.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double root1;
            double root2;
            
            if(d == 0)
            {
                Console.Write("Both roots are equal");
                root1 = -b / (2 * a);
                root2 = root1;
                Console.Write($"First root = {root1}");
                Console.Write($"Second root = {root2}");
            }
            else if(d > 0)
            {
                Console.Write("The roots are different!");
                root1 = (-b + Math.Sqrt(d)) / (2 * a);
                root2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.Write($"First root = {root1}");
                Console.Write($"Second root = {root2}");
            }
            else
            {
                Console.Write("Roots are imaginary!");
            }
            Console.WriteLine()

            // 5.
            Console.WriteLine();
            Console.WriteLine("Enter a number between 1 and 9: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write(number * 10);
                break; 
                case 4:
                case 5:
                case 6:
                    Console.Write(number * 100);
                break;
                case 7:
                case 8:
                case 9:
                    Console.Write(number * 1000);
                break;
                default:
                    Console.Write("Warning!!!\nBound exceeded!");
                break;
            }
            Console.WriteLine();

            // 6.
            Console.WriteLine();
            Console.WriteLine("Please enter a number: ");
            int num = Int32.Parse(Console.ReadLine());

            for(int i = 1; i < num; i++)
            {
                if(i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine();

            // 7.
            Console.WriteLine();
            for(int card = 1; card <= 13; card++)
            {
                for(int suit = 1; suit <= 4; suit++)
                {
                    switch(suit)
                    {
                        case 1:
                        Console.Write("Club ");
                        break;
                        case 2:
                        Console.Write("Diamond ");
                        break;
                        case 3:
                        Console.Write("Heart ");
                        break;
                        case 4:
                        Console.Write("Spades ");
                        break;
                    }
                }

                switch(card)
                {
                    case 1:
                    Console.WriteLine("2");
                    break;
                    case 2:
                    Console.WriteLine("3");
                    break;
                    case 3:
                    Console.WriteLine("4");
                    break;
                    case 4:
                    Console.WriteLine("5");
                    break;
                    case 5:
                    Console.WriteLine("6");
                    break;
                    case 6:
                    Console.WriteLine("7");
                    break;
                    case 7:
                    Console.WriteLine("8");
                    break;
                    case 8:
                    Console.WriteLine("9");
                    break;
                    case 9:
                    Console.WriteLine("10");
                    break;
                    case 10:
                    Console.WriteLine("J");
                    break;
                    case 11: 
                    Console.WriteLine("Q");
                    break;
                    case 12:
                    Console.WriteLine("K");
                    break;
                    case 13:
                    Console.WriteLine("A");
                    break;
                }
            }

            // 8.
            Console.WriteLine();
            int sequenceFibonacci = 0;
            int fibonacciSequence = 1;
            int sum = 0;

            Console.Write("Enter any number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write($"{sequenceFibonacci}, {fibonacciSequence}");

            for(int i= 2; i < n; i++)
            {
                int fibSequence = sequenceFibonacci + fibonacciSequence;
                Console.Write("{0},", fibSequence);
                sequenceFibonacci = fibonacciSequence;
                fibonacciSequence = fibSequence;
                sum += i;
            }
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine();
            
            // 9.
            Console.WriteLine();
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] spiral = new int [n, n];

            int positionX = n;
            int positionY = n % 2 == 0? (n/2) -1 : (n/2);

            int direction = 3;
            int stepCount = 3;
            int stepPosition = 0;
            int stepChange = 0;

            for(int i = 0; i < n * n; i++)
            {
                spiral[positionX, positionY] = i;

                if(stepPosition < stepCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;

                    if(stepPosition == 1)
                    {
                        stepCount++;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }
                switch (direction)
                {
                    case 0:
                    positionX++;
                    break;
                    case 1:
                    positionY--;
                    break;
                    case 2:
                    positionX--;
                    break;
                    case 3:
                    positionY++;
                    break;
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("{0, 2}", spiral[i, j]);
                }
            }
            Console.WriteLine();

            // 10.
            Console.WriteLine();
            int[] arr = new int [20];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine()

            // 11.
            Console.WriteLine();
            bool arrayIsEqual = true;
            Console.WriteLine("Enter length of first array: ");
            int m = int.Parse(Console.ReadLine());
            int[] firstArray = new int[m];

            for(int j = 0; j < firstArray.Length; j++)
            {
                Console.Write("Enter element {0}: ", j);
                firstArray[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter length of second array: ");
            int n = int.Parse(Console.ReadLine());
            int[] secondArray = new int[n];   

            
            for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write("The two arrays are equal.");
                }
            Console.WriteLine();

            // 14.
            Console.WriteLine();
            Console.WriteLine("Enter decimal number to convert to binary: ");
            int decimalNum = Int32.Parse(Console.ReadLine());
            string binaryNum = Convert.ToString(decimalNum, 2);

            Console.WriteLine($"Binary form of {decimalNum} is: {binaryNum}");
            Console.WriteLine();

            // 15.
            Console.WriteLine();
            Console.WriteLine("Enter binary number to convert to decimal: ");
            string numBinary = Console.ReadLine();
            int numDecimal = Convert.ToInt32(numBinary, 2);

            Console.WriteLine($"Decimal form of {numBinary} is: {numDecimal}");
            Console.WriteLine();

            // 16.
            Console.WriteLine();
            Console.WriteLine("Enter decimal number to convert to hexadecimal: ");
            int dexNum  = Int32.Parse(Console.ReadLine());
            string hexNum = dexNum.ToString("X");

            Console.WriteLine($"Hexadecimal form of {dexNum} is: {hexNum}");
            Console.WriteLine();

            // 17.
            Console.WriteLine();
            Console.WriteLine("Enter hexadecimal number to convert to decimal: ");
            string hexaNum = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(hexaNum, 16);

            Console.WriteLine($"Decimal form of {hexaNum} is: {decimalNumber}");
            Console.WriteLine();

            // 18. 
            Console.WriteLine();
            Console.WriteLine("Enter hexadecimal number to convert to binary: ");
            string hexadexNumber = Console.ReadLine();
            int numDex = Convert.ToInt32(hexadexNumber, 16);
            string binaNum = Convert.ToString(numDex, 2);

            Console.WriteLine($"Binary form of {hexadexNumber} is: {binaNum}");
            Console.WriteLine();

            // 19.
            Console.WriteLine();
            Console.WriteLine("Enter binary number to convert to hexadecimal: ");
            string binaryNumber = Console.ReadLine();
            int numDex = Convert.ToInt32(binaryNumber, 2);
            string hexadecimalNumber = numDex.ToString("X");

            Console.WriteLine($"Hexadecimal form of {binaryNumber} is: {hexadecimalNumber}");
            Console.WriteLine();
            
            






        }
    }
}
