using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionAnnswe1
{
    internal class Program
    {
        //    //1
        //    public static bool CheckAge(int num)
        //    {
        //        if (num >= 18 && num <= 65)
        //        {
        //            return true;
        //        }
        //        else if (num < 0 || num > 120)
        //        {
        //            return false;
        //        }
        //        return false;
        //    }
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Please enter your age: ");
        //        int age = int.Parse(Console.ReadLine());
        //        bool isValid = CheckAge(age);
        //        if (isValid)
        //        {
        //            Console.WriteLine("You are within the valid age range.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are not within the valid age range.");
        //        }
        //    }

        //2 ??
        //public static string FormeName(string firstName, string lastName)
        //    { return $"{lastName} {firstName}"; }

        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Please enter your first name: ");
        //        string firstName = Console.ReadLine();
        //        Console.WriteLine("Please enter your last name: ");
        //        string lastName = Console.ReadLine();

        //        string fullName = FormeName(firstName, lastName);
        //        Console.WriteLine($"Your full name is: {fullName}");


        //    }


        //3
        //public static bool IsStrongPassword(string password)
        //    {
        //        if (password.Length >= 8 )
        //        {
        //            if (password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsLower))
        //            {
        //                return true;
        //            }  
        //        }
        //        return false;

        //    }
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Please enter your password: ");
        //        string password = Console.ReadLine();
        //        bool isStrong = IsStrongPassword(password);
        //        if (isStrong)
        //        {
        //            Console.WriteLine(true);
        //        }
        //        else
        //        {
        //            Console.WriteLine(false);
        //        }
        //    }

        //4
//        public static int SumIfEven(int[] numbers)
//        {
//            int sum = 0;
//            foreach (int number in numbers)
//            {
//                if (number % 2 == 0)
//                {
//                    sum += number;
//                }
//            }
//            return sum;   
//        }
//        static void Main(string[] args)
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 6 };
//            int result = SumIfEven(numbers);
//            Console.WriteLine($"The sum of even numbers is: {result}");
//        }
//    }
//}
