using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {            
            PublicRectangle r = new PublicRectangle();
            r.length = 105;
            r.width = 122;            
            r.Display();
        }
    }
}
