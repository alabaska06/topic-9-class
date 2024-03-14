using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_9
{
    internal class Student
    {
        private static Random generator = new Random();
        private string _firstName;
        private string _lastName;
        private int _studentNum;
        private string _email;

       

        public Student(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;

            _studentNum = generator.Next(0, 999);
            _studentNum = (_studentNum + 555000);
            
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                this._firstName = value;

            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
            }
        }

        public int studentNum
        {
            get
            {
                return _studentNum;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
        public void ResetStudentNumber()
        {
            _studentNum = generator.Next(0, 999);
            _studentNum = (_studentNum + 555000);
        }
        private void GenerateEmail()
        {
            _email = (_firstName.Substring(0, 3) + _lastName.Substring(0, 3) + (_studentNum % 1000) + "@gotvdsb.ca");
        }
    }
}
