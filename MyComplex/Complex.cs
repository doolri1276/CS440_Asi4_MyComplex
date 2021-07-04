using System;
using System.Collections.Generic;
using System.Text;

namespace MyComplex
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }
        public override string ToString()
        {
            if (Real > 0)
                return Real.ToString() + "+i" + Imag.ToString();
            else
                return Real.ToString() + "-i" + Math.Abs(Imag).ToString();
        }

        public static Complex operator+(Complex lhs, Complex rhs)
        {
            Complex res = new Complex();
            res.Real = lhs.Real + rhs.Real;
            res.Imag = lhs.Imag + rhs.Imag;
            return res;
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            Complex res = new Complex();
            res.Real = lhs.Real - rhs.Real;
            res.Imag = lhs.Imag - rhs.Imag;
            return res;
        }

        public static Complex operator /(Complex lhs, Complex rhs)
        {
            Complex res = new Complex();
            double a = lhs.Real;
            double b = lhs.Imag;
            double c = rhs.Real;
            double d = rhs.Imag;

            res.Real = (a*c+b*d)/(c*c+d*d);
            res.Imag = (b*c-a*d)/ (c * c + d * d);
            return res;
        }

        public static Complex operator *(Complex lhs, Complex rhs)
        {
            Complex res = new Complex();
            res.Real = lhs.Real * rhs.Real- lhs.Imag*rhs.Imag;
            res.Imag = lhs.Imag *rhs.Real+ lhs.Real*rhs.Imag;
            return res;
        }

        public static bool operator <(Complex lhs, Complex rhs)
        {
            if(lhs.Imag != 0 || rhs.Imag != 0)
                throw new InvalidOperationException("You cannot compare imaginary number.");

            if (lhs.Real < rhs.Real)
                return true;
            else
                return false;
        }

        public static bool operator >(Complex lhs, Complex rhs)
        {
            if(lhs.Imag!=0 || rhs.Imag!=0)
                throw new InvalidOperationException("You cannot compare imaginary number.");

            if (lhs.Real > rhs.Real)
                return true;
            else
                return false;
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Real==rhs.Real && lhs.Imag==rhs.Imag;
        }

        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.Real!=rhs.Real && rhs.Imag!=lhs.Imag;
        }

        public static Complex operator ++(Complex lhs)
        {
            lhs.Real++;
            return lhs;
        }

        public static Complex operator --(Complex lhs)
        {
            lhs.Real--;
            return lhs;
        }
    }

}
