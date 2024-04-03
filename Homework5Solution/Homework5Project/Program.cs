using System;

namespace Homework5Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BrettHancock
            //Question 1
            Console.WriteLine("Answer for question 1");
            int[] myArr = { 6, 7, 3, 4, 0, 5, 7, 8, 1, 2, 6, 7, 8, 4, 9 };
            int counter = 0;
            int greatestValue = int.MinValue;
            do
            {
                if (myArr[counter] > greatestValue)
                {
                    greatestValue = myArr[counter];
                }
                counter++;
            } while (counter < myArr.Length);
            Console.WriteLine($"The largest value in the array is {greatestValue}");
            //Question 2
            Console.WriteLine("Answer for question 2");
            int inputNum;
            Console.Write("Please enter an integer number between 0 and 9 (inclusive):");
           bool isNum =int.TryParse(Console.ReadLine(), out inputNum);

            while (isNum == false || (inputNum<0 || inputNum >9))
            {
              Console.Write("the number should be an integer between 0..9 (inclusive), please re-enter");
                isNum = int.TryParse(Console.ReadLine(), out inputNum);

            }
            //Question 3
            Console.WriteLine("Answer for question 3");
            counter = 0;
            int numCounter = 0;
            do
            {
                if (myArr[counter] == inputNum)
                {
                    numCounter++;
                }
                counter++;
            } while (counter < myArr.Length);
            Console.WriteLine($"The frequency of {inputNum} is: {numCounter}");
            //Question 4
            Console.WriteLine("Answer for question 4");
            int inputCounter = 0;
            do
            {
                counter = 0;
                numCounter = 0;
                do
                {
                    if (myArr[counter] == inputCounter)
                    {
                        numCounter++;
                    }
                    counter++;
                } while (counter < myArr.Length);
                Console.WriteLine($"The frequency of {inputCounter} is: {numCounter}");
                
                inputCounter++;
            } while (inputCounter<=9);
            //Question 5
            Console.WriteLine("Answer for question 5");
            int greatestCounter = 0;
            int numberMost = 0;
            inputCounter = 0;
            do
            {
                counter = 0;
                numCounter = 0;
                do
                {
                    if (myArr[counter] == inputCounter)
                    {
                        numCounter++;
                    }
                    counter++;
                } while (counter < myArr.Length);
                if (numCounter > greatestCounter)
                {
                    numberMost = inputCounter;
                    greatestCounter = numCounter;
                }

                inputCounter++;
            } while (inputCounter <= 9);
            Console.WriteLine($"The most frequent number is: {numberMost}");
            //Question 6
            Console.WriteLine("Answer for question 6");
            double average = 0;
            counter = 0;
            do
            {
                average += myArr[counter];
                counter++;
             } while (counter < myArr.Length);

            average /= myArr.Length;
            Console.WriteLine($"The Average is: {average}");

            //Question 7
            Console.WriteLine("Answer for question 7");
            int evenCounter = 0;
            counter = 0;
            do
            {
               if( myArr[counter] %2 ==0)
                {
                    evenCounter++;
                }
                counter++;
            } while (counter < myArr.Length);
            Console.WriteLine($"The array has {evenCounter} even numbers.");
            //Question 8
            Console.WriteLine("Answer for question 8");
                                  
            Console.Write("Please enter an integer number: ");
            isNum = int.TryParse(Console.ReadLine(), out inputNum);

            while (isNum == false)
            {
                Console.Write("the number should be an integer, please re-enter: ");
                isNum = int.TryParse(Console.ReadLine(), out inputNum);

            }
            counter = 0;
            numCounter = 0;
            do
            {
                if (myArr[counter] < inputNum)
                {
                    numCounter++;
                }
                counter++;
            } while (counter < myArr.Length);
            Console.WriteLine($"The array has {numCounter} numbers that are less than {inputNum}");

            //Question 9
            Console.WriteLine("Answer for question 9");
            counter = 0;
            int primeCounter = 0;
            int primeTester;
            do
            {
                primeTester = myArr[counter] - 1;
                if (myArr[counter] > 1)
                {
                    while (myArr[counter] % primeTester != 0)
                    {
                        primeTester--;
                    }
                    if (primeTester == 1)
                    {
                        primeCounter++;
                    }
                }
                counter++;
            } while (counter < myArr.Length);

            Console.WriteLine($"The array has {primeCounter} prime numbers");
        }
    }
}