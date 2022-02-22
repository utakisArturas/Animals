using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0222
{
    public interface IMammal<T> where T : class
    {
        T GiveBirth(string name, int age);
    }
}
