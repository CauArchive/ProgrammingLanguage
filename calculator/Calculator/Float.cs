public class Float
{
  public float value;

  public Float(float value)
  {
    this.value = value;
  }

  public override string ToString()
  {
    return value.ToString();
  }

  public static implicit operator float(Float f)
  {
    return f.value;
  }

  public static Float operator +(Float a, Float b)
  {
    return new Float(a.value + b.value);
  }
  public static Float operator +(Float a, Number b)
  {
    return new Float(a.value + b.value);
  }
  public static Float operator +(Number a, Float b)
  {
    return new Float(a.value + b.value);
  }
  public static Float operator -(Float a, Float b)
  {
    return new Float(a.value - b.value);
  }
  public static Float operator -(Float a, Number b)
  {
    return new Float(a.value - b.value);
  }
  public static Float operator -(Number a, Float b)
  {
    return new Float(a.value - b.value);
  }
  public static Float operator *(Float a, Float b)
  {
    return new Float(a.value * b.value);
  }
  public static Float operator *(Float a, Number b)
  {
    return new Float(a.value * b.value);
  }
  public static Float operator *(Number a, Float b)
  {
    return new Float(a.value * b.value);
  }
  public static Float operator /(Float a, Float b)
  {
    return new Float(a.value / b.value);
  }
  public static Float operator /(Float a, Number b)
  {
    return new Float(a.value / b.value);
  }
  public static Float operator /(Number a, Float b)
  {
    return new Float(a.value / b.value);
  }
}
