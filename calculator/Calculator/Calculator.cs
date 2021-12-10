using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static Number;
using static Float;

public class Calculator
{
  Stack<dynamic> stack = new Stack<dynamic>();
  public void Enter(dynamic value)
  {
    stack.Push(value);
    Console.WriteLine("=====Enter===");
    Console.Write("Enter: ");
    Console.WriteLine(value.ToString());
  }
  public void Clear()
  {
    stack.Clear();
    Console.WriteLine("=============");
    Console.WriteLine("=====Clear===");
    Console.WriteLine("=============");
  }
  public void Add()
  {
    if (stack.Count < 2)
      throw new Exception("Stack is empty");
    dynamic a = stack.Pop();
    dynamic b = stack.Pop();
    stack.Push(a + b);
    Console.WriteLine("=====ADD=====");
    Console.Write("Result: ");
    Console.WriteLine(stack.Peek().ToString());
  }
  public void Sub()
  {
    if (stack.Count < 2)
      throw new Exception("Stack is empty");
    dynamic a = stack.Pop();
    dynamic b = stack.Pop();
    stack.Push(a - b);
    Console.WriteLine("=====Sub=====");
    Console.Write("Result: ");
    Console.WriteLine(stack.Peek().ToString());
  }
  public void Mul()
  {
    if (stack.Count < 2)
      throw new Exception("Stack is empty");
    dynamic a = stack.Pop();
    dynamic b = stack.Pop();
    stack.Push(a * b);
    Console.WriteLine("=====Mul=====");
    Console.Write("Result: ");
    Console.WriteLine(stack.Peek().ToString());
  }
  public void Div()
  {
    if (stack.Count < 2)
      throw new Exception("Stack is empty");
    dynamic a = stack.Pop();
    dynamic b = stack.Pop();
    stack.Push(a / b);
    Console.WriteLine("=====Div=====");
    Console.Write("Result: ");
    Console.WriteLine(stack.Peek().ToString());
  }
}

// // Enable here to execute Simple Calculator
// public class Program
// {
//   public static void Main(string[] args)
//   {
//     Calculator calc = new Calculator();
//     // for Add
//     calc.Enter(new Number(1));
//     calc.Enter(new Number(2));
//     calc.Add();
//     calc.Enter(new Number(3));
//     calc.Add();
//     calc.Enter(new Float(1.5f));
//     calc.Add();
//     calc.Clear();

//     // for Sub
//     calc.Enter(new Number(1));
//     calc.Enter(new Number(2));
//     calc.Sub();
//     calc.Enter(new Number(3));
//     calc.Sub();
//     calc.Enter(new Float(1.5f));
//     calc.Sub();
//     calc.Clear();

//     // for Mul
//     calc.Enter(new Number(1));
//     calc.Enter(new Number(2));
//     calc.Mul();
//     calc.Enter(new Number(3));
//     calc.Mul();
//     calc.Enter(new Float(1.5f));
//     calc.Mul();
//     calc.Clear();

//     // for Div
//     calc.Enter(new Number(1));
//     calc.Enter(new Number(2));
//     calc.Div();
//     calc.Enter(new Number(3));
//     calc.Div();
//     calc.Enter(new Float(1.5f));
//     calc.Div();
//     calc.Clear();

//     // for Complicated
//     calc.Enter(new Number(1));
//     calc.Enter(new Number(2));
//     calc.Add();
//     calc.Enter(new Number(3));
//     calc.Mul();
//     calc.Enter(new Float(1.5f));
//     calc.Div();
//     calc.Enter(new Float(1.5f));
//     calc.Mul();
//     calc.Enter(new Number(100));
//     calc.Add();
//     calc.Enter(new Float(14.2f));
//     calc.Div();
//     calc.Clear();
//   }
// }