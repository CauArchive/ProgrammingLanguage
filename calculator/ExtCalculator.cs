using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Calculator;
using static Complex;
using static Rational;
using static Float;
using static Number;

public class Program
{
  public static void Main(string[] args)
  {
    Calculator calc = new Calculator();
    // for Add
    calc.Enter(new Number(1));
    calc.Enter(new Number(2));
    calc.Add();
    calc.Enter(new Number(3));
    calc.Add();
    calc.Enter(new Float(1.5f));
    calc.Add();
    calc.Enter(new Rational(1, 2));
    calc.Add();
    calc.Enter(new Complex(1, 2));
    calc.Add();
    calc.Clear();

    // for Sub
    calc.Enter(new Number(1));
    calc.Enter(new Number(2));
    calc.Sub();
    calc.Enter(new Number(3));
    calc.Sub();
    calc.Enter(new Float(1.5f));
    calc.Sub();
    calc.Enter(new Rational(1, 2));
    calc.Sub();
    calc.Enter(new Complex(1, 2));
    calc.Sub();
    calc.Clear();

    // for Mul
    calc.Enter(new Number(1));
    calc.Enter(new Number(2));
    calc.Mul();
    calc.Enter(new Number(3));
    calc.Mul();
    calc.Enter(new Float(1.5f));
    calc.Mul();
    calc.Enter(new Rational(1, 2));
    calc.Mul();
    calc.Enter(new Complex(2.5f, 2));
    calc.Mul();
    calc.Clear();

    // for Div
    calc.Enter(new Number(1));
    calc.Enter(new Number(2));
    calc.Div();
    calc.Enter(new Number(3));
    calc.Div();
    calc.Enter(new Float(1.5f));
    calc.Div();
    calc.Enter(new Rational(1, 2));
    calc.Div();
    calc.Enter(new Complex(2.5f, 2));
    calc.Div();
    calc.Clear();

    // for Complicated
    calc.Enter(new Number(1));
    calc.Enter(new Number(2));
    calc.Add();
    calc.Enter(new Number(3));
    calc.Mul();
    calc.Enter(new Float(1.5f));
    calc.Div();
    calc.Enter(new Rational(1, 2));
    calc.Add();
    calc.Enter(new Complex(2.5f, 2));
    calc.Add();
    calc.Enter(new Complex(2.5f, 2));
    calc.Add();
    calc.Enter(new Float(1.5f));
    calc.Mul();
    calc.Enter(new Number(100));
    calc.Add();
    calc.Enter(new Float(14.2f));
    calc.Div();
    calc.Clear();
  }
}