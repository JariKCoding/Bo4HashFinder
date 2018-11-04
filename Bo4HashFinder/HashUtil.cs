using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo4HashFinder
{
    class HashUtil
    {
        public static ulong Hash(string input)
        {
            ulong num = 14695981039346656037;
            for (int index = 0; index < input.Length; ++index)
                num = (ulong)(((long)num ^ (long)input[index]) * 1099511628211L);
            num &= 0xFFFFFFFFFFFFFFF;
            return num;
        }
    }
}
