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


            #region Q11
            //11. Show position number alongside ProductName 
            var PostionWithNameOfProduct = Source.ProductList.Select((p, i) => new
            {
                Pos = i + 1,
                ProductName = p.ProductName,
            });
            foreach (var Product in PostionWithNameOfProduct)
            {
                Console.WriteLine($"{Product.Pos}. {Product.ProductName}");
            }

            #endregion
        }
    }
}
