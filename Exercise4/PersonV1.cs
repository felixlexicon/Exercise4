using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    internal class PersonV1
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public PersonV1(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} is {_age} years old.";
        }
    }
}
