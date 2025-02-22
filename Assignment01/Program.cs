
using LINQ;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static LINQ.ListGenerator;

namespace Assignment01

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 . Find all products that are out of stock.
            //var first = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in first)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2
            //var first = ProductList.Where(p => p.UnitsInStock >= 0 && p.UnitPrice > 3.00m);
            //foreach (var item in first)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            //var result = ProductList.Where((p, i) => p.ProductName.Length < i);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4

            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            // LINQ – Transformation Operators
            #region Q1
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordCases = words.Select(word => new
            //{
            //    Uppercase = word.ToUpper(),
            //    Lowercase = word.ToLower()
            //});
            #endregion

            #region Q3
            //var result = ProductList.Select(p => new
            //{
            //    Id = p.ProductID,
            //    Name = p.ProductName,
            //    Price = p.UnitPrice
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = Arr.Select((p, i) => p == i);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            5
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select (a, b);

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.a} is less than {pair.b}");
            }

            #endregion
        }
    }
}
