// See https://aka.ms/new-console-template for more information
using stackalgo;

Console.WriteLine("Hello, World!");

MyStack s = new MyStack();
s.Push(3);
s.Push(5);
s.getMin();
s.Push(2);
s.Push(1);
s.getMin();
s.Pop();
s.getMin();
s.Pop();
s.Peek();
