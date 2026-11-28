using LINQ1.DataSource;
using LINQ1.Models;
using System.Collections.Generic;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1. Get all products from the "Seafood" category. Print each product's name and price.
            //var SeacFoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");
            //foreach (var product in SeacFoodProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}$");
            //} 
            #endregion

            #region Q2
            // 2. Get a list of only the product names from ProductList. Print each name.
            //var ProudctNames = Source.ProductList.Select(p => p.ProductName);
            //foreach (var name in ProudctNames)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Q3
            // 3. Sort all products by UnitPrice (ascending). Print each product's name and price.
            //var SortedProducts = Source.ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var Product in SortedProducts)
            //{
            //    Console.WriteLine($"{Product.ProductName} - {Product.UnitPrice}$");
            //} 
            #endregion

            #region Q4
            // 4. Get all products where UnitPrice is between 10 and 30.
            //var ProductsBetween10And30 = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var p in ProductsBetween10And30)
            //{
            //    Console.WriteLine(p);
            //} 
            #endregion

            #region Q5
            // 5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
            //var InStockCondiments = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //foreach (var product in InStockCondiments)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region Q6
            //var AnonymousProducts = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Availabe" : "OutOfStock"
            //});

            //foreach (var product in AnonymousProducts)
            //{
            //    Console.WriteLine(product);

            //} 
            #endregion

            #region Q7
            //7.Print each product's name along with its position (1-based) 
            //in the list. Expected format: 1.Chai, 2.Chang, etc.
            //var ProductsWithPosition = Source.ProductList.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    Name = p.ProductName
            //});
            //foreach (var product in ProductsWithPosition)
            //{
            //    Console.WriteLine($"{product.Position}. {product.Name}");
            //} 
            #endregion

            #region Q8
            /*8. Sort ProductList by Category ascending, then within each 
                 category, sort by UnitPrice descending.*/

            //var SortedProducts = Source.ProductList.OrderBy(p => p.Category)
            //                    .ThenByDescending(p => p.UnitPrice);
            //foreach (var product in SortedProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q9
            /*9. Get all products from the "Beverages" category, sorted by 
            UnitsInStock descending. Print name and stock.*/

            //var BeveragesProducts = Source.ProductList
            //                        .Where(p => p.Category == "Beverages")
            //                        .OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in BeveragesProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitsInStock}");
            //}
            #endregion

            #region Q10
            /*10. Using QUERY SYNTAX with a compound from clause, list 
                all orders placed in 1997 or later showing CustomerID and 
                OrderDate.*/

            //var OrdersIn1997OrLater = from customer in Source.CustomerList
            //                          from order in customer.Orders
            //                          where order.OrderDate.Year >= 1997
            //                          select new
            //                          {
            //                              CustomerID = customer.CustomerID,
            //                              OrderDate = order.OrderDate
            //                          };
            //foreach (var order in OrdersIn1997OrLater)
            //{
            //    Console.WriteLine($"CustomerID: {order.CustomerID}, OrderDate: {order.OrderDate.ToShortDateString()}");
            //}
            #endregion

            #region Q11
            //11. Show position number alongside ProductName 
            //var PostionWithNameOfProduct = Source.ProductList.Select((p, i) => new
            //{
            //    Pos = i + 1,
            //    ProductName = p.ProductName,
            //});
            //foreach (var Product in PostionWithNameOfProduct)
            //{
            //    Console.WriteLine($"{Product.Pos}. {Product.ProductName}");
            //}

            #endregion


            #region Q12
            /*12. Sort first by-word length and then by a 
            case-insensitive sort of the words in an array.*/


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedWords = Arr.OrderBy(w => w.Length).
            //                  ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in SortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Q13
            /*13. Create a list of all digits in the array whose second 
                    letter is 'i' that is reversed from the order in the 
                    original array. */


            string[] DigitsArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var NewDigitsArr = DigitsArr.Where(x => x[1] == 'i').Reverse();
            foreach (var digit in NewDigitsArr)
            {
                Console.WriteLine(digit);
            }
            #endregion


        }
    }
}
