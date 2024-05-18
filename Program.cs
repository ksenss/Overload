using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Square
    {
        int a;
        public int A { get; set; }
        public Square() { A = 1; }
        public Square(int a) { A = a; }

        public override string ToString()
        {
            return $"A:{A} ";
        }
        public static Square operator +(Square p,Square b)
        {
            Square res = new Square
            {
                A = p.A+b.A,
            
            };
            return res;
        }
        public static Square operator *(Square p1, Square p2)
        {
            Square res = new Square
            {
               A = p1.A * p2.A,
               
            };
            return res;
        }
        public static Square operator /(Square p1, Square p2)
        {
            Square res = new Square
            {
                A = p1.A /p2.A,

            };
            return res;
        }
        public static Square operator ++(Square p)
        {
            p.A++;
            
            return p;
        }
        public static Square operator --(Square p)
        {
            p.A--;
            return p;
        }
        public static bool operator ==(Square p1, Square p2)
        {
            return p1.A == p2.A ;
        }
        //in pair
        public static bool operator !=(Square p1, Square p2)
        {
            return !(p1 == p2);
        }
        public static bool operator >(Square p1, Square p2)
        {
            return p1.A > p2.A;
        }
        //in pair
        public static bool operator <(Square p1, Square p2)
        {
            return p1.A < p2.A;
        }
        public static bool operator >=(Square p1, Square p2)
        {
            return p1.A >= p2.A;
        }
        //in pair
        public static bool operator <=(Square p1,Square p2)
        {
            return p1.A <= p2.A;
        }
        public static bool operator true(Square a)
        {
            return a.A != 0;
        }
        public static bool operator false(Square a)
        {
            return a.A == 0;
        }
        public static implicit operator Rectangle(Square a)
        {
            return new Rectangle(a.A, a.A + 3);
        }
        public static implicit operator int(Square a)
        {
            return a.A*a.A;
        }
    }
    class Rectangle
    {
        int a;
        int b;
        public int A { get; set; }
        public int B { get; set; }
        public Rectangle() { A = 1; B = 2; }
        public Rectangle(int a, int b) { A = a; B = b; }

        public override string ToString()
        {
            return $"A:{A},B:{B} ";
        }
        public static Rectangle operator ++(Rectangle p)
        {
            p.A++;
            p.B ++;
            return p;
        }
        public static Rectangle operator --(Rectangle p)
        {
            p.A--;
            p.B--;
            return p;
        }
        public static Rectangle operator +(Rectangle p1, Rectangle p2)
        {
            Rectangle res = new Rectangle
            {
               A = p1.A + p2.A,
               B = p1.B + p2.B
            };
            return res;
        }
        public static Rectangle operator -(Rectangle p1, Rectangle p2)
        {
            Rectangle res = new Rectangle

            {
                A = p1.A - p2.A,
                B = p1.B - p2.B
            };
            return res;
        }
        public static Rectangle operator*(Rectangle p1, Rectangle p2)
        {
            Rectangle res = new Rectangle

            {
                A = p1.A * p2.A,
                B = p1.B * p2.B
            };
            return res;
        }
        public static Rectangle operator /(Rectangle p1, Rectangle p2)
        {
            Rectangle res = new Rectangle

            {
                A = p1.A / p2.A,
                B = p1.B /p2.B
            };
            return res;
        }
        public static bool operator true(Rectangle a)
        {
            return a.A != 0 ||a.B!=0;
            
        }
        public static bool operator false(Rectangle a)
        {
            return a.A == 0 && a.B==0;
        }
        public static explicit operator Square(Rectangle a)
        {
            return new Square(a.A + a.B);
        }
        public static explicit operator int(Rectangle a)
        {
            return a.A * a.B;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square kwadrat= new Square(1);
            Square kwadrat2 = new Square(2);
            kwadrat.ToString();
            Console.WriteLine(kwadrat+kwadrat2);
        }
    }
}
