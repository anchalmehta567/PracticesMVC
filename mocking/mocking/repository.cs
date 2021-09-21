using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mocking
{
    public class repository
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public virtual  int sub(int a, int b) 
        {
            throw new NotImplementedException();
        }
    }
}
