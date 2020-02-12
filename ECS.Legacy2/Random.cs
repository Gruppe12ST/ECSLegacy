using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy2
{
    class RandomProvider: IRandom
    {
        private Random gen = new Random();

        public int GetRandom()
        {
            return gen.Next(-5, 45);
        }
    }
}
