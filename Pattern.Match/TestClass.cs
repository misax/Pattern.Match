using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Match
{
    public class TestClass
    {
        public abstract class Account
        {
        }

        public class Student : Account { }

        public class Individual : Account
        {
            public double PersentageDiscount { get; set; }
        }

        public class Businness : Account
        {
            public int Employees { get; set; }
        }

        public class Test
        {
            public static double ApplyDiscount(Account ac, double discount)
            {
                switch (ac)
                {
                    case null:
                           throw new ArgumentNullException(nameof(ac));
                    case Student _:
                            return 0;
                    case Individual individual:
                        return discount * (1 - individual.PersentageDiscount / 100);
                    case Businness bussBusinness when bussBusinness.Employees <= 50:
                                return discount * 0.7;
                    case Businness bussinness:
                        return discount * 0.9;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
    }
}
