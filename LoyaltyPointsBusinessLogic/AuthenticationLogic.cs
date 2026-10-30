using LoyaltyPointsData;

namespace LoyaltyPointsBusinessLogic
{
    public class AuthenticationLogic
    {
        UserData userData = new UserData();
        StudentDataService studentDS = new StudentDataService();
        FacultyDataService facultyDS = new FacultyDataService();

        FacultyJsonDataService facultyJsonDS;

        public bool IsFacultyNumberCorrect(string userinput)
        {
            facultyJsonDS = new FacultyJsonDataService();
            return facultyJsonDS.IsFacultyNumberExists(userinput);
        }

        public bool IsStudentNumberCorrect(string userinput)
        {

            return studentDS.IsStudentNumberExists(userinput);
        }
    }
}
