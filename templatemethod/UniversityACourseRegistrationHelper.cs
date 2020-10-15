using System;
namespace templatemethod
{
    public class UniversityACourseRegistrationHelper : CourseRegistrationMethod
    {       
        public override void ProcessPayment()
        {
            Console.WriteLine("UniversityA Cash Payment");
        }

        public override void SendNotificaction()
        {
            Console.WriteLine("UniversityA Notification sended");
        }

        public override void VerifyPrerequisites()
        {
            Console.WriteLine("UniversityA Payment recived");
        }
    }
}
