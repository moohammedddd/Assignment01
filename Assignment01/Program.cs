
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
            
            var result = ProductList.Select(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
