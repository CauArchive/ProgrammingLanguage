using System;
public class Rational
{
  public int numerator = 0;
  public int denominator = 1;

  public Rational(int int_value)
  {
    set(int_value, 1);
  }
  public override string ToString()
  {
    if (denominator == 1)
      return numerator.ToString();
    else if (numerator == 0)
      return "0";
    else if (numerator % denominator == 0)
      return (numerator / denominator).ToString();
    else
      return numerator + "/" + denominator;
  }
  public static implicit operator float(Rational r)
  {
    return (r.numerator / (float)r.denominator);
  }
  public Rational(int numerator, int denominator)
  {
    set(numerator, denominator);
  }
  public void set(int numerator, int denominator)
  {
    if (denominator == 0)
    {
      throw new ArithmeticException("Denominator must not be 0");
    }
    this.numerator = numerator;
    this.denominator = denominator;
  }

  private void fix_denominator(Rational other)
  {
    int tmp = denominator;
    numerator *= other.denominator;
    denominator *= other.denominator;

    other.numerator *= tmp;
    other.denominator *= tmp;
  }

  public static explicit operator int(Rational r)
  {
    return (int)r.numerator / (int)r.denominator;
  }

  public static Rational operator +(Rational r)
  {
    return new Rational(r.numerator, r.denominator);
  }

  public static Rational operator -(Rational r)
  {
    return new Rational(-r.numerator, r.denominator);
  }

  // for Adder
  // Rational + Rational
  // Rational + Number
  // Number + Rational
  // Rational + Float
  // Float + Rational
  public static Rational operator +(Rational r1, Rational r2)
  {
    r1.fix_denominator(r2);
    return new Rational(r1.numerator + r2.numerator, r1.denominator);
  }

  public static Rational operator +(Number r1, Rational r2)
  {
    return new Rational(r1.value * r2.denominator + r2.numerator, r2.denominator);
  }

  public static Rational operator +(Rational r1, Number r2)
  {
    return new Rational(r2.value * r1.denominator + r1.numerator, r1.denominator);
  }

  public static Rational operator +(Float r1, Rational r2)
  {
    return new Rational((int)(r1.value * r2.denominator + r2.numerator), r2.denominator);
  }

  public static Rational operator +(Rational r1, Float r2)
  {
    return new Rational((int)(r2.value * r1.denominator + r1.numerator), r1.denominator);
  }

  // for Subtractor
  // Rational - Rational
  // Rational - Number
  // Number - Rational
  // Rational - Float
  // Float - Rational
  public static Rational operator -(Rational r1, Rational r2)
  {
    r1.fix_denominator(r2);
    return new Rational(r1.numerator - r2.numerator, r1.denominator);
  }

  public static Rational operator -(Number r1, Rational r2)
  {
    return new Rational(r1.value * r2.denominator - r2.numerator, r2.denominator);
  }

  public static Rational operator -(Rational r1, Number r2)
  {
    return new Rational(r2.value * r1.denominator - r1.numerator, r1.denominator);
  }

  public static Rational operator -(Float r1, Rational r2)
  {
    return new Rational((int)(r1.value * r2.denominator - r2.numerator), r2.denominator);
  }

  public static Rational operator -(Rational r1, Float r2)
  {
    return new Rational((int)(r2.value * r1.denominator - r1.numerator), r1.denominator);
  }

  // for Multiplier
  public static Rational operator *(Rational r1, Rational r2)
  {
    return new Rational(r1.numerator * r2.numerator, r1.denominator * r2.denominator);
  }

  public static Rational operator *(Number r1, Rational r2)
  {
    return new Rational(r1.value * r2.numerator, r2.denominator);
  }

  public static Rational operator *(Rational r1, Number r2)
  {
    return new Rational(r2.value * r1.numerator, r1.denominator);
  }

  public static Rational operator *(Float r1, Rational r2)
  {
    return new Rational((int)(r1.value * r2.numerator), r2.denominator);
  }

  public static Rational operator *(Rational r1, Float r2)
  {
    return new Rational((int)(r2.value * r1.numerator), r1.denominator);
  }

  // for Divider
  public static Rational operator /(Rational r1, Rational r2)
  {
    if (r2.numerator == 0)
    {
      throw new DivideByZeroException();
    }
    return new Rational(r1.numerator * r2.denominator, r1.denominator * r2.numerator);
  }

  public static Rational operator /(Number r1, Rational r2)
  {
    if (r2.numerator == 0)
    {
      throw new DivideByZeroException();
    }
    return new Rational(r1.value * r2.denominator, r2.numerator);
  }

  public static Rational operator /(Rational r1, Number r2)
  {
    if (r2.value == 0)
    {
      throw new DivideByZeroException();
    }
    return new Rational(r1.numerator, r1.denominator * r2.value);
  }

  public static Rational operator /(Float r1, Rational r2)
  {
    if (r2.numerator == 0)
    {
      throw new DivideByZeroException();
    }
    return new Rational((int)(r1.value * r2.denominator), r2.numerator);
  }

  public static Rational operator /(Rational r1, Float r2)
  {
    if (r2.value == 0)
    {
      throw new DivideByZeroException();
    }
    return new Rational(r1.numerator, (int)(r1.denominator * r2.value));
  }
}