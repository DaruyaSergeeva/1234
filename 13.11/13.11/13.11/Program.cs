using _13._11.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    class Program
    {


        static public (int, bool) GetValues(string a, string b)
        {

            try
            {
                int c = Convert.ToInt32(a);
                int d = Convert.ToInt32(b);
            }
            catch
            {
                throw new MyException();
            }
            return (1, true);

        }


        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число a");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число b");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 1, если необходима сумма;");
            Console.WriteLine("Введите 2, если необходима разность;");
            Console.WriteLine("Введите 3, если необходимо умножение;");
            Console.WriteLine("Введите 4, если необходимо деление");
            var c = (Operation)Convert.ToInt32(Console.ReadLine());

            int result = 0;
            if (!Enum.IsDefined(typeof(Operation), c))
            {
                Console.WriteLine("(((");
                return;
            }
            switch (c)
            {
                case Operation.Add:
                    result = a + b;
                    break;
                case Operation.Subtract:
                    result = a - b;
                    break;
                case Operation.Multiply:
                    result = a * b;
                    break;
                case Operation.Divide:
                    {
                        try
                        {
                            result = a / b;
                        }
                        catch
                        {
                            Console.WriteLine("Делить на 0 нельзя!");
                            break;

                        };
                        result = a / b;
                        break;
                    };
            }

            Console.WriteLine("Результат операции равен {0}", result);
            Console.ReadKey();
        }
    }
}
