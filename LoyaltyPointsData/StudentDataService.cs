using System;
using System.Collections.Generic;
using System.Text;

namespace LoyaltyPointsData
{
    public class StudentDataService
    {
        private List<string> studentnumbers = new List<string>();

        public StudentDataService()
        {
            PopulateDummyStudentNumbers();
        }

        private void PopulateDummyStudentNumbers()
        {
            studentnumbers.Add("2011-00066-BN-0");
            studentnumbers.Add("2012-00066-BN-0");
            studentnumbers.Add("2013-00066-BN-0");
            studentnumbers.Add("2014-00066-BN-0");
            studentnumbers.Add("2015-00066-BN-0");
            studentnumbers.Add("2016-00066-BN-0");
        }

        public List<string> RetrieveAllStudentNumbers()
        {
            return studentnumbers;
        }

        public bool IsStudentNumberExists(string studentNumber)
        {
            foreach (string number in studentnumbers)
            {
                if (number.Equals(studentNumber.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        //public List<string> GetStudentNumber(string studentNumber)
        //{
        //    List<string> result = new List<string>();

        //    if (string.IsNullOrWhiteSpace(studentNumber))
        //        return result;

        //    foreach (string number in studentnumbers)
        //    {
        //        if (number.Equals(studentNumber.Trim(), StringComparison.OrdinalIgnoreCase))
        //        {
        //            result.Add(number);
        //        }
        //    }

        //    return result;
        //}

        //public List<string> LambdaGetStudentNumber(string studentNumber)
        //{
        //    return studentnumbers
        //        .Where(n => n.Equals(studentNumber?.Trim(), StringComparison.OrdinalIgnoreCase))
        //        .ToList();
        //}

        //public bool AddStudentNumber(string studentNumber)
        //{
        //    if (string.IsNullOrWhiteSpace(studentNumber))
        //        return false;

        //    string cleaned = studentNumber.Trim().ToUpper();

        //    foreach (string number in studentnumbers)
        //    {
        //        if (number.Equals(cleaned, StringComparison.OrdinalIgnoreCase))
        //            return false; // already exists
        //    }

        //    studentnumbers.Add(cleaned);
        //    return true;
        //}
    }
}
