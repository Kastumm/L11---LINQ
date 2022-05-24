using System;
using System.Linq;

namespace LessonL11
{
    public static class AssignmentL11
    {
        //Closures
        public static void Main(string[] args)
        {
            var inc = GetAFunc();
            Console.WriteLine(inc(5));
            Console.WriteLine(inc(6));

        }

        public static Func<int, int> GetAFunc()
        {
            var myVar = 1;
            Func<int, int> inc = delegate (int var1)
            {
                myVar = myVar + 1;
                return var1 + myVar;
            };
            return inc;
        }
    }

    //LINQ Implemented in my project


}