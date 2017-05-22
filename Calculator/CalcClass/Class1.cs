using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcClass
{
    public class Class1
    {
        public static int Add(long a, long b)
        {
            if (a < -2147483648 || a > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (b < -2147483648 || b > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if ((a + b) < -2147483648 || (a + b) > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            return (int)(a + b);
        }

        public static int Sub(long a, long b)
        {
            if (a < -2147483648 || a > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (b < -2147483648 || b > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if ((a - b) < -2147483648 || (a - b) > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            return (int)(a - b);
        }

        public static int Mult(long a, long b)
        {
            if (a < -2147483648 || a > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (b < -2147483648 || b > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if ((a * b < -2147483648) || (a * b > 2147483648))
            {
                _lastError = "Error 06";
                return 0;
            }
            return (int)(a * b);
        }

        public static int Div(long a, long b)
        {
            if (b == 0)
            {
                _lastError = "Error 09 : ділення на 0";
                return 0;
            }
            if (a < -2147483648 || a > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (b < -2147483648 || b > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (a / b < -2147483648 || a / b > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }


            else
                return Int16.Parse((a / b).ToString());
        }

        public static int Mod(long a, long b)
        {
            if (b == 0)
            {
                _lastError = "Error 09 : ділення на 0";
                return 0;
            }
            if (a < -2147483648 || a > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (b < -2147483648 || b > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (a % b < -2147483648 || a % b > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            return Int16.Parse((a % b).ToString());
        }

        public static int ABS(long a)
        {
            if (a < -2147483648 || a > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            if (a < -2147483648 || a > 2147483648)
            {
                _lastError = "Error 06";
                return 0;
            }
            return Int16.Parse((Math.Abs(a)).ToString());
        }

        public static int IABS(long a)
        {
            if ((a < -2147483648) || (a > 2147483648))
            {
                _lastError = "Error 06";
                return 0;
            }
            if (((Int16.Parse("0") - a) < -2147483648) || ((Int16.Parse("0") - a) > 2147483648))
            {
                _lastError = "Error 06";
                return 0;
            }
            return Int16.Parse((Int16.Parse("0") - a).ToString());
        }
        public static string _lastError = "";
    }
}
