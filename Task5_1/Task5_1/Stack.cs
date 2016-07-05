//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics;

//namespace Task5_1
//{
//    class Stack : IFunctionsForCollections
//    {
//        const int numberToAdd = 1000;
//        const int numberToDelete = 100;
//        const int numberForFind = 123;
//        Stack<int> stack;
//        Stopwatch sw;

//        public Stack()
//        {
//            sw = new Stopwatch();
//            stack = new Stack<int>();
//        }
//        public long AddElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for (int i = 0; i < numberToAdd; i++)
//            {
//                stack.Push(i);
//            }
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }


//        public long DeleteElements()
//        {
//            try
//            {
//                sw.Reset();
//                sw.Start();
//                for (int i = 0; i < numberToDelete; i++)
//                {
//                    stack.Pop();
//                }
//                sw.Stop();
//                long result = sw.ElapsedMilliseconds;
//                return result;
//            }
//            catch (ArgumentOutOfRangeException)
//            {
//                return 0;
//            }
//        }

//        public long FindElements()
//        {
//            sw.Reset();
//            sw.Start();
//            stack.Contains(numberForFind);
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }

//        public long ReadElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for (int i = 0; i < stack.Count; i++)
//            {
//                stack.ElementAt(i);
//            }
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }

//        public void CallingFunctions()
//        {
//            WriteToFile wr = new WriteToFile();
//            wr.Write($"Stack( Add:{AddElements().ToString()},Delete:{DeleteElements().ToString()}," +
//              $"Find:{FindElements().ToString()},Read:{ReadElements().ToString()})");
//        }
//    }
//}
