using System;
using System.Collections.Generic;
using System.Text;

namespace MyComplex
{
    public class Currency
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }


        public static Currency operator +(Currency lhs, Currency rhs)
        {
            Currency res = new Currency();
            res.Dollars = lhs.Dollars + rhs.Dollars;
            res.Cents = lhs.Cents + rhs.Cents;
            if (res.Cents >= 100)
            {
                res.Dollars++;
                res.Cents -= 100;
            }
            return res;
        }
        public static Currency operator -(Currency lhs, Currency rhs)
        {
            Currency res = new Currency();
            res.Dollars = lhs.Dollars - rhs.Dollars;
            res.Cents = lhs.Cents - rhs.Cents;
            if (res.Cents < 0)
            {
                res.Dollars--;
                res.Cents += 100;
            }
            return res;
        }

        public static bool operator <(Currency lhs, Currency rhs)
        {
            if (lhs.Dollars == rhs.Dollars)
                return lhs.Cents < rhs.Cents;
            else 
                return lhs.Dollars < rhs.Dollars;
        }

        public static bool operator >(Currency lhs, Currency rhs)
        {
            if (lhs.Dollars == rhs.Dollars)
                return lhs.Cents < rhs.Cents;
            else
                return lhs.Dollars < rhs.Dollars;
        }

        public static bool operator ==(Currency lhs, Currency rhs)
        {
            return lhs.Dollars == rhs.Dollars && lhs.Cents == rhs.Cents;
        }

        public static bool operator !=(Currency lhs, Currency rhs)
        {
            return lhs.Dollars != rhs.Dollars && rhs.Cents != lhs.Cents;
        }

        public static Currency operator ++(Currency lhs)
        {
            lhs.Dollars++;
            return lhs;
        }

        public static Currency operator --(Currency lhs)
        {
            lhs.Dollars--;
            return lhs;
        }
    }
}
