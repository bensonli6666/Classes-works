using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_works
{
    class Student
    {
        private string name;

        private int studentID;

        private string dob;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int StudentID
        {
            get { return studentID; }

            set { studentID = value; }
        }

        public string Dob
        {
            get { return dob; }

            set { dob = value; }
        }

        public Student(string argsName, int argsStudentID, string argsDob)
        {
            name = argsName;

            studentID = argsStudentID;

            dob = argsDob;
        }
    }
}
