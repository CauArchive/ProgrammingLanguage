
public class Number
{
  public int value;
  public Number(int value)
  {
    this.value = value;
  }

  public override string ToString()
  {
    return value.ToString();
  }
  public static implicit operator int(Number num)
  {
    return num.value;
  }
  public static Number operator +(Number a, Number b)
  {
    return new Number(a.value + b.value);
  }
  public static Number operator -(Number a, Number b)
  {
    return new Number(a.value - b.value);
  }
}
