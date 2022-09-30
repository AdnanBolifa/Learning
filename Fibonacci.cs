using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnging
{
    public class Fibonacci
    {
        int n;
        public Fibonacci(int n)
        {
            this.n = n;
        }
        public void print()
        {
            int n1 = 0;
            int n2 = 1;
            int temp = 0;
            System.Console.Write("0 1 ");
            while (temp < this.n)
            {
                temp = n1 + n2;
                n1 = n2;
                n2 = temp;
                System.Console.Write(temp + " ");
            }
        }
    }
}