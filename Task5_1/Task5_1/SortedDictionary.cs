//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics;

//namespace Task5_1
//{
//    class SortedDictionary : IFunctionsForCollections
//    {
//        SortedDictionary <int,int> sortedDictionary;
//        const int numberToAdd = 1000;
//        const int numberToDelete = 100;
//        const int numberForFind = 123;
//        Stopwatch sw;

//        public SortedDictionary()
//        {
//            sortedDictionary = new SortedDictionary<int,int>();
//            sw = new Stopwatch();
//        }

//        public long AddElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for (int i = 0; i < numberToAdd; i++)
//            {
//                sortedDictionary.Add(i,i);
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
//                    sortedDictionary.Remove(i);
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
//            sortedDictionary.ContainsValue(numberForFind);
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }

//        public long ReadElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for (int i = 0; i < sortedDictionary.Count; i++)
//            {
//                sortedDictionary.ElementAt(i);
//            }
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }
//        public void CallingFunctions()
//        {
//            WriteToFile wr = new WriteToFile();
//            wr.Write($"SortedDictionary( Add:{AddElements().ToString()},Delete:{DeleteElements().ToString()}," +
//              $"Find:{FindElements().ToString()},Read:{ReadElements().ToString()})");
//        }
//    }
//}

