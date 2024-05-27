using System;
using System.Collections.Generic;

class StackMachine
{
    private Stack<int> stack;

    public StackMachine()
    {
        stack = new Stack<int>();
    }

    public void Push(int value)
    {
        stack.Push(value);
    }

    public int Pop()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Stack is empty");
        return stack.Pop();
    }

    public void Add()
    {
        if (stack.Count < 2)
            throw new InvalidOperationException("Not enough elements in the stack");
        int b = stack.Pop();
        int a = stack.Pop();
        stack.Push(a + b);
    }

    public void Sub()
    {
        if (stack.Count < 2)
            throw new InvalidOperationException("Not enough elements in the stack");
        int b = stack.Pop();
        int a = stack.Pop();
        stack.Push(a - b);
    }

    public void Mul()
    {
        if (stack.Count < 2)
            throw new InvalidOperationException("Not enough elements in the stack");
        int b = stack.Pop();
        int a = stack.Pop();
        stack.Push(a * b);
    }

    public void Div()
    {
        if (stack.Count < 2)
            throw new InvalidOperationException("Not enough elements in the stack");
        int b = stack.Pop();
        int a = stack.Pop();
        if (b == 0)
            throw new DivideByZeroException("Division by zero");
        stack.Push(a / b);
    }

    public int Peek()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Stack is empty");
        return stack.Peek();
    }

    
}

class Program
{
    static void Main()
    {
        StackMachine machine = new StackMachine();

        machine.Push(3);
        machine.Push(4);
        machine.Add();
        machine.Push(2);
        machine.Mul();
        Console.WriteLine("Resultado: " + machine.Peek());
    }
}