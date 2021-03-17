using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityCheck1
{
    public class EqualityChecker
    {
        private readonly object _x;
        private readonly object _y;
        public bool CheckTypeAndValue() => _x.Equals(_y);
        public EqualityChecker(object x, object y)
        {
            _x = x;
            _y = y;
        }
    }
}
