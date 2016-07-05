using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    interface IFunctionsForCollections
    {
        TimeSpan AddElements();
        long ReadElements();
        long DeleteElements();
        long FindElements();
        void CallingFunctions();
    }
}
