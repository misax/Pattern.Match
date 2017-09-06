using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Match.UIS
{
    class Program
    {
        private static async Task MainAsync()
        {
            var result = await new HttpClient().GetStringAsync("http://www.seznam.cz");
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
             const int x = 2;
            const int y = 3;
           
            MathHelper.Test();
            

            var output = MathHelper.Calculate(x, y);

            Console.WriteLine($"{x} + {y} = {output.Sum}");
            Console.WriteLine($"{x} * {y} = {output.Product}");


            var result = MathHelper.Compute(1, 2, 3, 4);

            Console.WriteLine($"Suma je: {result.Sum}");
            Console.WriteLine($"Produkt je: {result.Product}");


            var student = new TestClass.Student();
            var individual = new TestClass.Individual { PersentageDiscount = 50 };
            var business1 = new TestClass.Businness { Employees = 100 };
            var business2 = new TestClass.Businness { Employees = 2000 };

            const int price = 100;

          Console.WriteLine($"Student:\t{TestClass.Test.ApplyDiscount(student, price)}");
          Console.WriteLine($"Individuals:\t{TestClass.Test.ApplyDiscount(individual, price)}");
          Console.WriteLine($"SmallBusinnes:\t{TestClass.Test.ApplyDiscount(business1, price)}");
          Console.WriteLine($"BigBusiness:\t{TestClass.Test.ApplyDiscount(business2, price)}");
        }
    }
}
