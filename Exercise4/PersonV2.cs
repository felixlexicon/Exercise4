using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    internal class PersonV2
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private decimal _salary;

        public PersonV2(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                ValidateName(value, "First name cannot contain fewer than 3 symbols!");
                _firstName = value.Trim();
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                ValidateName(value, "Last name cannot contain fewer than 3 symbols!");
                _lastName = value.Trim();
            }
        }
        public int Age
        {
            get { return _age; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                _age = value;
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set 
            { 
                if (value < 460.00m)
                {
                    throw new ArgumentException("Salary cannot be less than 460.00 dollar!");
                }
                _salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (percentage > 0)
            {
                if (this.Age < 30)
                {
                    percentage /= 2;
                }
                this.Salary *= (1 + percentage / 100);
            }
        }

        private void ValidateName(string? name, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Trim().Length < 3)
            {
                throw new ArgumentException(errorMessage);
            }
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} receives {_salary:C}.";
        }
    }
}
