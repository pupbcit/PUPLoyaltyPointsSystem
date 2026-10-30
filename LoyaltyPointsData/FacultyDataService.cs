using System;
using System.Collections.Generic;
using System.Text;

namespace LoyaltyPointsData
{
    public class FacultyDataService
    {
        public FacultyDataService()
        {
            PopulateDummyStudentNumbers();
        }

        private void PopulateDummyStudentNumbers()
        {
            FacultyNumbers. Add(new Faculty() { FacultyID = "2016ABC000", FacultyName = "Indaleen" });
            FacultyNumbers. Add(new Faculty() { FacultyID = "2015ABC000", FacultyName = "Hedwig" });
            FacultyNumbers. Add(new Faculty() { FacultyID = "2014ABC000", FacultyName = "Buckbeak" });
            
        }

        public List<Faculty> FacultyNumbers { get; } = new List<Faculty>();

        public bool IsFacultyNumberExists(string facultynumber)
        {
            //foreach (string number in FacultyNumbers)
            //{
            //    if (number.Equals(facultynumber.Trim(), StringComparison.OrdinalIgnoreCase))
            //    {
            //        return true;
            //    }
            //}

            return false;
        }
    }
}
