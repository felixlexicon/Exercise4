# 1. Sort Persons by Name and Age

Create a class Person, which should have private fields for:

- firstName: string
- lastName: string
- age: int
- ToString(): string - override

**Examples**

**Input**

- Anna Persson 65
- Anna Andersson 34
- Johanna Eriksson 57
- Johanna Svensson 27
- Erika Samuelsson 35

**Output**

- Anna Andersson is 34 years old.
- Anna Persson is 65 years old.
- Erika Samuelsson is years old.
- Johanna Svensson is 27 years old.
- Johanna Eriksson is 57 years old.

# Salary Increase

Refactor project from last task.

Read person with their names, age and salary. Read percent bonus to every person salary.

People younger than 30 get half the increase. Expand Person from the previous task.

New fields and methods:

- salary: decimal
- IncreaseSalary(decimal percentage)

**Examples**

**Input**

- Ida Svensson 65 2200
- Berit Dahl 57 3333
- Bert Lewinsson 27 600
- Anna Hamren 44 666.66
- Jacob Andersson 35 559.4

**Output**

- Ida Svensson receives 2640.00 dollars.
- Berit Dahl receives 3999.60 dollars.
- Bert Lewinsson receives 660.00 dollars.
- Anna Hamren receives 799.99 dollars.
- Jacob Andersson receives 671.28 dollars.

# Validation of Data

Expand Person with proper validation for every field:

- Names must be at least 3 symbols
- Age must not be zero or negative
- Salary can't be less than 460.0

Print proper messages to the user:

- “Age cannot be zero or a negative integer!”
- “First name cannot contain fewer than 3 symbols!”
- “Last name cannot contain fewer than 3 symbols!”
- “Salary cannot be less than 460 dollar!”

Use ArgumentExeption with messages from example.

**Examples**

**Input**

- Anna Ivanov -6 2200
- B Dahl 57 3333
- Hanna Ma 27 600
- Asen Holm 44 200
- Mikael Johansson 35 500
- 20

**Output**

- Age cannot be zero or a negative integer!
- First name cannot contain fewer than 3 symbols!
- Last name cannot contain fewer than 3 symbols!
- Salary cannot be less than 460 dollars!
- Boris Magnusson gets 660.00 dollars.
