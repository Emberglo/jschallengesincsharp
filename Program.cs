using System;

namespace jsincsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            doubleInteger(2);
            isNumberEven(3);
            isNumberEven(4);
            fileExtension("rpg.jpg");
            fileExtension("wazzup");
            string[] array1 = new string[] { "Hi", "Hello", "Hey" };
            longestString(array1);
            int[] array2 = new int[] { 1, 2, 3, 4 };
            arraySum(array2);
        }

        public static int doubleInteger(int num)
        {
            int doubleNum = num * 2;
            System.Console.WriteLine(doubleNum);
            return doubleNum;
        }

        public static bool isNumberEven(int num)
        {
            if (num % 2 == 0)
            {
                System.Console.WriteLine("true");
                return true;
            }
            else
            {
                System.Console.WriteLine("false");
                return false;
            }
        }

        public static string fileExtension(string str)
        {
            //need to do a string split
            // string result = string.Empty;
            // string toRemove = ".";
            // int index = str.IndexOf(toRemove);
            // if (str.LastIndexOf(".") > -1)
            // {
            //     result = str.Remove(index, toRemove.Length);
            // }
            // Console.WriteLine(str);
            // Console.WriteLine(result);
            // return result;

            if (str.LastIndexOf(".") > -1)
            {
                string[] strings = str.Split(".");
                System.Console.WriteLine(strings[strings.Length - 1]);
                return strings[strings.Length - 1];
            }
            System.Console.WriteLine("No file extension");
            return null;
        }

        public static string longestString(string[] array1)
        {
            string longest = String.Empty;
            for (int i = 0; i < array1.Length; i++)
            {
                longest = array1[i].Length > longest.Length ? array1[i] : longest;
            }
            Console.WriteLine(longest);
            return longest;
        }

        public static int arraySum(int[] array2)
        {
            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum += array2[i];
            }
            System.Console.WriteLine(sum);
            return sum;
        }
    }
}
//dotnet new webapi -o name