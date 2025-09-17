using System;

namespace Task2;

public class Student
{
    string fullname;
    int age;
    int grade;

    public Student(string fullname, int age, int grade)
    {
        this.fullname = fullname;
        this.age = age;
        this.grade = grade;
    }
    public string Study()
    {
        return $"{fullname} is studying";
    }
    public void SetGrade(int newGrade)
    {
        grade = newGrade;
    }
    public int GetGrade()
    {
        return grade;
    }
}
