using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackalgo
{
    public class MyStack
    {
        public Stack<int> s;
        public int minEle;

        // Constructor
        public MyStack()
        {
            s = new Stack<int>();
        }

        public void Push(int n)
        {
            if(s.Count == 0)
            {
                minEle = n;
                s.Push(n);
                return;
            }
            
            if(n < minEle)
            {
                s.Push(2 * n - minEle);
                minEle = n;
            }
            else
            {
                s.Push(n);
            }
        }

        public void Pop()
        {
            if(s.Count == 0)
            {
                return;
            }

            int t = (int)s.Pop();
            if(t < minEle)
            {
                minEle = 2 * minEle - t;
            }
            
        }

        public void getMin()
        {
            // Get the minimum number 
            // in the entire stack
            if (s.Count == 0)
                Console.WriteLine("Stack is empty");

            // variable minEle stores the minimum 
            // element in the stack.
            else
                Console.WriteLine("Minimum Element in the " +
                                " stack is: " + minEle);
        }

        public void Peek()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty ");
                return;
            }

            int t = (int)s.Peek(); // Top element.

            Console.Write("Top Most Element is: ");

            // If t < minEle means minEle stores
            // value of t.
            if (t < minEle)
                Console.WriteLine(minEle);
            else
                Console.WriteLine(t);
        }
    }
}
