using System;

namespace templatemethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello templates!");
            var helperA = new UniversityACourseRegistrationHelper();
            helperA.RegistrationMethod();

            var helperB = new UniversityBCourseRegistrationHelper();
            helperB.RegistrationMethod();

            Console.ReadLine();
        }
    }
}
