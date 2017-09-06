using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Match
{
    public class MathHelper
    {
        public static (int Sum, int Product) Compute(params int[] numbers)
        {
            return (numbers.Sum(), numbers.Aggregate(1, (x, y) => x * y));
        }

        public static void CalculateOut(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

        public static (int Sum, int Product) Calculate(int x, int y)
        {
            return (x + y, x * y);
        }

        public static void Test()
        {
            const int x = 2;
            const int y = 3;
           CalculateOut(x,y,out int sum0 , out int product0);
            Console.WriteLine($"{x} + {y} = {sum0}");
            Console.WriteLine($"{x} * {y} = {product0}");

            int sum;
            int product;
            ( sum,product) = Calculate(y, x);

            Console.WriteLine($"{sum}");
            Console.WriteLine($"{product}");
        }
    }
}
