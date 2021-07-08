using System;

namespace csharp_beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1, y=2 ;
            int tNum ;
            tNum = x ;
            x = y ;
            y = tNum ;
            var sth = 'r' ;
            Console.WriteLine("Say sth : " + sth) ;
            Console.WriteLine("x = " + x + " and y = " + y);    
        }
    }
}
