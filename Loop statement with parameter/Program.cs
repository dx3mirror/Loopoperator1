using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_statement_with_parameter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var printer = new DescendingNumberPrinter();
            printer.Iterate();
        }
        public abstract class NumberIterator
        {
            public void Iterate()
            {
                for (var i = GetStart(); i >= GetEnd(); i += GetStep())
                {
                    Print(i);
                }
            }

            protected abstract int GetStart();

            protected abstract int GetEnd();

            protected abstract int GetStep();

            protected abstract void Print(int i);
        }
        public class DescendingNumberPrinter : NumberIterator
        {
            protected override int GetStart()
            {
                return 100;
            }

            protected override int GetEnd()
            {
                return 80;
            }

            protected override int GetStep()
            {
                return -1;
            }

            protected override void Print(int i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
