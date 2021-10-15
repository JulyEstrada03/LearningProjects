namespace  Encapsulation 
{        
    public class PublicRectangle
    {
      public int length;
      public int width;
      public double GetArea() {
         return length * width;
      }

      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }

      
    }
}