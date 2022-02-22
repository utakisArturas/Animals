using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0222
{
    public class DogsComparer : IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
