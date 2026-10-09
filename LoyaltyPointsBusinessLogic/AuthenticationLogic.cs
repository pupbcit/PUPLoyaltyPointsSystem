using LoyaltyPointsData;

namespace LoyaltyPointsBusinessLogic
{
    public class AuthenticationLogic
    {
        UserData userData = new UserData();

        public bool IsFacultyNumberCorrect(string userinput)
        {
            return userinput == userData.facultyNumber;
        }

        public bool IsStudentNumberCorrect(string userinput)
        {
            return userinput == userData.studentNumber;
        }
    }
}
