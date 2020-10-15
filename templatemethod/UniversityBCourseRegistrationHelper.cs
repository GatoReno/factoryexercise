using System;
namespace templatemethod
{
    public class UniversityBCourseRegistrationHelper : CourseRegistrationMethod
    {
     
        public override void ProcessPayment()
        {
            Console.WriteLine("UniversityB payment in process ");
        }

        public override void SendNotificaction()
        {
            Console.WriteLine("UniversityB notification mail sent");
        }

        public override void VerifyPrerequisites()
        {
            Console.WriteLine("UniversityB verified requisites ");
        }
    }
}
