//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics;

//namespace Task5_1
//{
//    class List : IFunctionsForCollections
      
//    {
//        const int numberToAdd = 1000;
//        const int numberToDelete = 100;
//        const int numberForFind = 123;
//        List<int> list;
//        Stopwatch sw;     
//        public List()
//        {
//            sw = new Stopwatch();
//            list = new List<int>();
//        }
//        public long AddElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for(int i = 0; i < numberToAdd; i++)
//            {
//                list.Add(i);
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
//                    list.RemoveAt(i);
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
//            list.Contains(numberForFind);
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;

//        }

//        public long ReadElements()
//        {
//            sw.Reset();
//            sw.Start();
//            for (int i = 0; i < list.Count; i++)
//            {
//                list.ElementAt(i);
//            }
//            sw.Stop();
//            long result = sw.ElapsedMilliseconds;
//            return result;
//        }

//        public void CallingFunctions()
//        {
//            WriteToFile wr =  new WriteToFile();
//            wr.Write($"List( Add:{AddElements()},Delete:{DeleteElements().ToString()},"+
//              $"Find:{FindElements().ToString()},Read:{ReadElements().ToString()})");
            
//        }
//    }
//}
