namespace InheritanceExample
{
  internal class Triangle : Shape
  {
    public override void CalculateArea()
    {
      base.CalculateArea();
      int area = 0;
      Console.WriteLine($"Üçgen alanı {area}");
    }
  }
}