//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics;

//namespace Task5_1
//{
//    class Queue : IFunctionsForCollections
//    {
//        const int numberToAdd = 1000;
//        const int numberToDelete = 100;
//        const int numberForFind = 123;
//        Queue<int> queue;
//        Stopwatch sw;

//        public Queue()
//        {
//            sw = new Stopwatch();
//            queue = new Queue<int>();
//        }
//        public long AddElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for (int i = 0; i < numberToAdd; i++)
//            {
//                queue.Enqueue(i);
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
//                    queue.Dequeue();
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
//            queue.Contains(numberForFind);
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }

//        public long ReadElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for (int i = 0; i < queue.Count; i++)
//            {
//                queue.ElementAt(i);
//            }
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }

//        public void CallingFunctions()
//        {
//            WriteToFile wr = new WriteToFile();
//            wr.Write($"Queue( Add:{AddElements().ToString()},Delete:{DeleteElements().ToString()}," +
//              $"Find:{FindElements().ToString()},Read:{ReadElements().ToString()})");
//        }
//    }
//}
