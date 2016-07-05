using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Task5_1
{
    class Dictionary : IFunctionsForCollections
    {
        const int numberToAdd = 1000;
        const int numberToDelete = 100;
        const int numberForFind = 123;
        Dictionary<int,int> dictionary;
        Stopwatch sw;
        public Dictionary()
        {
            sw = new Stopwatch();
            dictionary = new Dictionary<int,int>();
        }
        public TimeSpan AddElements()
        {
            sw.Reset();
            sw.Start();
            for (int i = 0; i < numberToAdd; i++)
            {
                dictionary.Add(i,i);
            }
            sw.Stop();
            return sw.Elapsed;
        

        }

        public long DeleteElements()
        {
            try
            {
                sw.Reset();
                sw.Start();
                for (int i = 0; i < numberToDelete; i++)
                {
                    dictionary.Remove(i);
                }
                sw.Stop();
                long result = sw.ElapsedMilliseconds;
                return result;
            }
            catch (ArgumentOutOfRangeException)
            {
                return 0;
            }

        }

        public long FindElements()
        {
            sw.Reset();
            sw.Start();
            dictionary.ContainsValue(numberForFind);
            sw.Stop();
            long result = sw.ElapsedMilliseconds;
            return result;

        }

        public long ReadElements()
        {
            sw.Reset();
            sw.Start();
            for (int i = 0; i < dictionary.Count; i++)
            {
                dictionary.ElementAt(i);
            }
            sw.Stop();
            long result = sw.ElapsedMilliseconds;
            return result;
        }

        public void CallingFunctions()
        {
            WriteToFile wr = new WriteToFile();
            wr.Write($"Dictionary( Add:{AddElements().TotalMilliseconds},Delete:{DeleteElements().ToString()}," +
              $"Find:{FindElements().ToString()},Read:{ReadElements().ToString()})");
        }
        
    }
}
