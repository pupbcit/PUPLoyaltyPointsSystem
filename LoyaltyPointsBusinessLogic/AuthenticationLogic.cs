using LoyaltyPointsData;
using System.Net.Http.Headers;

namespace LoyaltyPointsBusinessLogic
{
    public class AuthenticationLogic
    {

        FacultyDBMSService facultyDBMSService;
        UserData userData = new UserData();
        StudentDataService studentDS = new StudentDataService();
        FacultyDataService facultyDS = new FacultyDataService();

        FacultyJsonDataService facultyJsonDS;
        StudentJsonDataService studentJsonDS;

        FacultyDBDataService FacultyDBDataService;

        public bool IsFacultyNumberCorrect(string userinput)
        {
            //facultyDBMSService = new FacultyDBMSService();

            FacultyDBDataService = new FacultyDBDataService();

            facultyJsonDS = new FacultyJsonDataService();
            return facultyJsonDS.IsFacultyNumberExists(userinput);
        }

        public bool IsStudentNumberCorrect(string userinput)
        {
            studentJsonDS = new StudentJsonDataService();
            return studentJsonDS.IsStudentNumberExists(userinput);
        }
    }
}
