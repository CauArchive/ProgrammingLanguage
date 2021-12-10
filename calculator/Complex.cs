public class Complex
{
  public float real;
  public float imaginary;
  public Complex(float real, float imaginary)
  {
    this.real = real;
    this.imaginary = imaginary;
  }
  // for Adder
  // Complex + Complex;
  // Complex + Number;
  // Number + Complex;
  // Complex + float;
  // float + Complex;
  // Complex + Rational;
  // Rational + Complex;

  public override string ToString()
  {
    return $"{real} + {imaginary}i";
  }
  public static Complex operator +(Complex a, Complex b)
  {
    return new Complex(a.real + b.real, a.imaginary + b.imaginary);
  }
  // for Subtractor
  public static Complex operator +(Complex a, Number b)
  {
    return new Complex(a.real + b.value, a.imaginary);
  }
  public static Complex operator +(Number a, Complex b)
  {
    return new Complex(a.value + b.real, b.imaginary);
  }
  public static Complex operator +(Complex a, float b)
  {
    return new Complex(a.real + b, a.imaginary);
  }
  public static Complex operator +(float a, Complex b)
  {
    return new Complex(a + b.real, b.imaginary);
  }
  public static Complex operator +(Complex a, Rational b)
  {
    return new Complex(a.real + (float)b, a.imaginary);
  }
  public static Complex operator +(Rational a, Complex b)
  {
    return new Complex((float)a + b.real, b.imaginary);
  }
  // for Subtractor

  public static Complex operator -(Complex a, Complex b)
  {
    return new Complex(a.real - b.real, a.imaginary - b.imaginary);
  }
  public static Complex operator -(Complex a, Number b)
  {
    return new Complex(a.real - b.value, a.imaginary);
  }
  public static Complex operator -(Number a, Complex b)
  {
    return new Complex(a.value - b.real, -b.imaginary);
  }
  public static Complex operator -(Complex a, Float b)
  {
    return new Complex(a.real - b.value, a.imaginary);
  }
  public static Complex operator -(Float a, Complex b)
  {
    return new Complex(a.value - b.real, -b.imaginary);
  }
  public static Complex operator -(Complex a, Rational b)
  {
    return new Complex(a.real - (float)b, a.imaginary);
  }
  public static Complex operator -(Rational a, Complex b)
  {
    return new Complex((float)a - b.real, -b.imaginary);
  }
  // for Multiplier
  public static Complex operator *(Complex a, Complex b)
  {
    return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + a.imaginary * b.real);
  }
  public static Complex operator *(Complex a, Number b)
  {
    return new Complex(a.real * b.value, a.imaginary * b.value);
  }
  public static Complex operator *(Number a, Complex b)
  {
    return new Complex(a.value * b.real, a.value * b.imaginary);
  }
  public static Complex operator *(Complex a, float b)
  {
    return new Complex(a.real * b, a.imaginary * b);
  }
  public static Complex operator *(float a, Complex b)
  {
    return new Complex(a * b.real, a * b.imaginary);
  }
  public static Complex operator *(Complex a, Rational b)
  {
    return new Complex(a.real * (float)b, a.imaginary * (float)b);
  }
  public static Complex operator *(Rational a, Complex b)
  {
    return new Complex((float)a * b.real, (float)a * b.imaginary);
  }
  // for Multiplier
  public static Complex operator /(Complex a, Complex b)
  {
    return new Complex((a.real * b.real + a.imaginary * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary), (a.imaginary * b.real - a.real * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary));
  }
  public static Complex operator /(Complex a, Number b)
  {
    return new Complex(a.real / b.value, a.imaginary / b.value);
  }
  public static Complex operator /(Number a, Complex b)
  {
    return new Complex(a.value / b.real, a.value / b.imaginary);
  }
  public static Complex operator /(Complex a, float b)
  {
    return new Complex(a.real / b, a.imaginary / b);
  }
  public static Complex operator /(float a, Complex b)
  {
    return new Complex(a / b.real, a / b.imaginary);
  }
  public static Complex operator /(Complex a, Rational b)
  {
    return new Complex(a.real / (float)b, a.imaginary / (float)b);
  }
  public static Complex operator /(Rational a, Complex b)
  {
    return new Complex((float)a / b.real, (float)a / b.imaginary);
  }
}