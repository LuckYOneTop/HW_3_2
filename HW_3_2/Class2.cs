using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2
{
    internal class Class2
    {
        private int result;

        public Class1.ShowDelegate Calc(Func<int, int, int> powDelegate, int x, int y)
        {
            result = powDelegate(x, y);

            Func<int, bool> resultDelegate = (num) => {
                return num % result == 0;
            };

            return (bool value) => 
            {
                Program.Show(resultDelegate(value));
            };
        }

        public bool Result(int x)
        {
            return x % result == 0;
        }
    }

}

