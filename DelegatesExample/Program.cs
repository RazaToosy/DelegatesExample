using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    namespace DelegatesExample
    {
        public delegate bool OperatorHandler(double ValueFromExternalSource, double ValueToCompare);

        public class Program
        {
            static void Main(string[] args)
            {
                ProcessData data = new ProcessData();

                bool isTrueForGreater = data.IsValueTrue(1.0, 2.0, new OperationRulesHandlers().GreaterThan);
                Console.WriteLine(String.Format("Is 1.0 greater than 2.0 --> Answer : {0}\n", isTrueForGreater));

                bool isTrueForLesser = data.IsValueTrue(1.0, 2.0, new OperationRulesHandlers().LessThan);
                Console.WriteLine(String.Format("Is 1.0 less than 2.0 --> Answer : {0}", isTrueForLesser));
                Console.ReadLine();
            }
        }

        public class OperationRulesHandlers
        {
            public OperatorHandler GreaterThan = (x, y) => { return x > y; };
            public OperatorHandler LessThan = (x, y) => { return x < y; };
        }

        public class ProcessData
        {
            public bool IsValueTrue(double externalValue, double compareValue, OperatorHandler operation)
            {
                return operation(externalValue, compareValue);
            }
        }
    }
