namespace InheritanceExample
{
  internal class Circle : Shape
  {
    public int Radius { get; set; }

    public override void CalculateArea()
    {
      base.CalculateArea();
      int area = 0;
      Console.WriteLine($"Circle area {area}");
    }
  }
}