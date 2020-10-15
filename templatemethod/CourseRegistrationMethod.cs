using System;
namespace templatemethod
{
    public abstract class CourseRegistrationMethod
    {
        public void RegistrationMethod()
        {
            VerifyPrerequisites();
            ProcessPayment();
            SendNotificaction();
        }

        public abstract void SendNotificaction();
        public abstract void ProcessPayment();
        public abstract void VerifyPrerequisites();
    }
}
