using System;
using System.Collections.Generic;
using System.Text;

namespace LoyaltyPointsData
{
    public class FacultyDataService
    {
        private List<string> facultyNumbers = new List<string>();

        public FacultyDataService()
        {
            PopulateDummyStudentNumbers();
        }

        private void PopulateDummyStudentNumbers()
        {
            facultyNumbers.Add("2015ABC000");
            facultyNumbers.Add("2016ABC000");
            facultyNumbers.Add("2017ABC000");
            facultyNumbers.Add("2018ABC000");
            facultyNumbers.Add("2019ABC000");
        }

        public List<string> RetriveAllFacultyNumbers()
        {
            return facultyNumbers;
        }

        public bool IsFacultyNumberExists(string facultynumber)
        {
            foreach (string number in facultyNumbers)
            {
                if (number.Equals(facultynumber.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
