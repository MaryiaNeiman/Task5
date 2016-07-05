using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5_1
{
    class WriteToFile
    {
        public  void Write(String inputStr)
        {
            try
            {
                File.AppendAllText(ResourceFile.Path, inputStr + "\r\n");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
