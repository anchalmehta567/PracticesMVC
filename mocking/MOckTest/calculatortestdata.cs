using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOckTest
{
    public class calculatortestdata : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>()
        {
            new object[]{ 15,30,45},
            new object[]{ -15,-30,-45},
            new object[]{ -15,30,15},
        };
        public IEnumerator<object> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }

        IEnumerator<object[]> IEnumerable<object[]>.GetEnumerator()
        {

            return this.data.GetEnumerator();
        }
    }
}
