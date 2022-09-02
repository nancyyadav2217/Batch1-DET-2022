//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class AssignmentLINQ
//    {


//        public static void Main()
//        {
//            Assignment1();
//            //Assignment2();
//            //Assignment3();
//            //Assignment4();
//            //Assignment5();
//        }
//        private static void Assignment1()
//        {
//            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
//            var result = from name in names
//                         where name.Contains('o')
//                         select name;
//            Console.WriteLine("The names in the list that contain 'o' are: ");
//            foreach (var name in result)
//            {
//                Console.WriteLine(name);
//            }

//            var result1 = names.OrderByDescending(c => c.Length);
//            var result2 = result1.First();
//            Console.WriteLine("The name with maximum number of charater lenght is: ");
//            Console.WriteLine(result2);


//        }

//        private static void Assignment2()
//        {
//            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

//            var result = names.Max();

//            Console.WriteLine(" names is:");
//            Console.WriteLine(result);
//        }

//        private static void Assignment3()
//        {
//            string[] words1 = { "believe", "relief", "receipt", "field" };
//            var result =
//        }
//        private static void Assignment4()
//        {
//            string[] names = {​​ "Blueberry", "Blackberry", "Abacus" };


//            var result = names.Reverse();
//            var result1 = names.OrderBy(n => n);


//            Console.WriteLine("value in reverse order:");
//            foreach (string character in result)
//                Console.WriteLine(character);
//        }

//        private static void Assignment5()
//        {
//            int[] numbers = { 1, 3, 2, 0 };
//            string[] names = {"C#", "SQL", "LINQ", "Java"};
                
//        }
//        }
//    }

