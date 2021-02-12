using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_11._02._21
{
    delegate T ShowMath<T>(T x, T y);

    public static class DoMath
    {
        public static T Add<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }
        public static T Substract<T>(T x, T y)
        {
            return (dynamic)x - (dynamic)y;
        }
        public static T Multiply<T>(T x, T y)
        {
            return Math.Round((dynamic)x * (dynamic)y, 2);
        }
        public static T Divide<T>(T x, T y)
        {
            return Math.Round((dynamic)x / (dynamic)y, 2);
        }

    }
}
