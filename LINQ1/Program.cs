using LINQ1.DataSource;

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
            var ProudctNames = Source.ProductList.Select(p => p.ProductName);
            foreach (var name in ProudctNames)
            {
                Console.WriteLine(name);
            }

            #endregion            
            // 3. Sort all products by UnitPrice (ascending). Print each product's name and price.
            // 4. Get all products where UnitPrice is between 10 and 30.
            // 5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
        }
    }
}
