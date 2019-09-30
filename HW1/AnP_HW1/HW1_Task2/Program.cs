using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Task2
{
  
    class Program
    {
        private delegate void Func();

        private static Man Man1 = new Man("Петя", "школьный друг", 30);
        private static Man Man2 = new Man("Вася", "сосед", 54);
        private static Man Man3 = new Man("Николай", "сын", 4);

        private List<Man> manList = new List<Man> { Man1, Man2, Man3 };

        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void WriteToConsole(string name, string description,
                                           int age)
        {
            Console.WriteLine(Format, name, description, Address, age);
        }


        private static void MakeAction(Func action)
        {
            string methodName = action.Method.Name;
            Console.WriteLine("Начало работы метода {0}", methodName);
            action();
            Console.WriteLine("Окончание работы метода {0}", methodName);
        }


        private static List<Func> GetActionSteps()
        {
            return new List<Func>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }


        static void Main(string[] args)
        {
            List<Func> actions = GetActionSteps();
            foreach (var action in actions)
            {
                MakeAction(action);
            }

            Console.ReadLine();
        }
    }
}
