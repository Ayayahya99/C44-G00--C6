namespace ConsoleApp2
{


    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("---------------------Q1----------------------");
            int x = 30;
            Console.WriteLine("x before ValueTypeFun = " + x);
            ValueTypeFun(x);
            Console.WriteLine("x after ValueTypeFun = " + x);

            Console.WriteLine("----------------");
            Console.WriteLine("x before RefranceTypeFun = " + x);
            RefranceTypeFun(ref x);
            Console.WriteLine("x after RefranceTypeFun = " + x);

            /***********************************************************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Q2----------------------");

            int[] arr = { 2, 4, 6, 7 };

            Console.WriteLine("value of array[0] before ChangeByValue = " + arr[0]);
            ChangeByValue(arr);
            Console.WriteLine("value of array[0] after ChangeByValue = " + arr[0]);

            Console.WriteLine("----------------");

            Console.WriteLine("value of array[0] before ChangeByRef = " + arr[0]);
            ChangeByRef(ref arr);
            Console.WriteLine("value of array[0] after ChangeByRef = " + arr[0]);

            /***********************************************************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Q3----------------------");

            Console.WriteLine("enter number1 ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number2 ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number3 ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number4 ");
            int n4 = int.Parse(Console.ReadLine());

            int sum, sub;
            SumAndSubFun(n1, n2, n3, n4, out sum, out sub);

            /***********************************************************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Q4----------------------");

            Console.WriteLine("enter your digit => ");
            int digit = int.Parse(Console.ReadLine());

            int sumOfDigit = sumdigits(digit);
            Console.WriteLine("sum of digit = " + sumOfDigit);

            /***********************************************************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Q5----------------------");

            Console.WriteLine("enter your number to check if it is prime or not:");
            int num22 = int.Parse(Console.ReadLine());

            bool p = IsPrime(num22);

            if (p)
            {
                Console.WriteLine("is prime number");
            }
            else
            {
                Console.WriteLine("not prime number");
            }

            /***********************************************************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Q6----------------------");

            int[] arr55 = { 3, 4, 1, 44, 6, 8 };

            int min = 0, max = 0;
            MinMaxArray(arr55, ref min, ref max);
            Console.WriteLine("max num is : " + max);
            Console.WriteLine("min num is : " + min);

            /***********************************************************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Q7----------------------");

            Console.WriteLine("Enter your number to find factorial:");
            int f = int.Parse(Console.ReadLine());
            int factorial = CalculateFactorial(f);

            Console.WriteLine("factorial of number is: " + factorial);

            /***********************************************************************************/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------Q8----------------------");

        }

        /***********************************************************************************/
        #region Q1 - Passing by value vs reference

        static void ValueTypeFun(int num)
        {
            num += 30;
            Console.WriteLine("num in ValueTypeFun = " + num);
        }

        static void RefranceTypeFun(ref int num)
        {
            num += 30;
            Console.WriteLine("num in RefranceTypeFun = " + num);
        }

        #endregion

        /***********************************************************************************/
        #region Q2 - Arrays and references

        static void ChangeByValue(int[] array)
        {
            array[0] = 99;
            array = new int[] { 100, 200 };
        }

        static void ChangeByRef(ref int[] array)
        {
            array[0] = 88;
            array = new int[] { 300, 400 };
        }

        #endregion

        /***********************************************************************************/
        #region Q3 - Sum and Subtract

        static void SumAndSubFun(int a, int b, int c, int d, out int sum, out int sub)
        {
            sum = a + b;
            sub = c - d;
            Console.WriteLine("sum of numbers = " + sum);
            Console.WriteLine("sub of numbers = " + sub);
        }

        #endregion

        /***********************************************************************************/
        #region Q4 - Sum of Digits

        static int sumdigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }

        #endregion

        /***********************************************************************************/
        #region Q5 - Prime Number

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        #endregion

        /***********************************************************************************/
        #region Q6 - Min Max in Array

        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = max = arr[0];

            foreach (int value in arr)
            {
                if (value < min)
                    min = value;
                if (value > max)
                    max = value;
            }
        }

        #endregion

        /***********************************************************************************/
        #region Q7 - Factorial (Iterative)

        static int CalculateFactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        #endregion

        /***********************************************************************************/
        #region Q8 - Placeholder for ChangeChar (not implemented)

       

        #endregion
    }

}
