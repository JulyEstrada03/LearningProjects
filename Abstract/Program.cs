using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ Abstract ---------------------");
            ClientNatural client = new ClientNatural(1, "UserName");
            Console.WriteLine(client.GetName());
        }
    }
}

