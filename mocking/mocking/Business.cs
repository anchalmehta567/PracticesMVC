using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mocking
{
 public   class Business
    {
        private repository repo;
        public Business(repository repo) 
        {
            this.repo = repo;
        }
        public int Addition(int a, int b) 
        {
            return this.repo.sum(a, b);
        }
        public int Subtraction(int a, int b)
        {
            return this.repo.sub(a, b);
        }



    }
}
