using System;

namespace Task1;

public class Teacher
{
    string fullName;
    string subject;
    int experience;
    public string Teach()
    {
        return $"Teacher {fullName} teaches {subject} with {experience} years of experience.";
    }
    public void SetExperience(int exp)
    {
        experience = exp;

    }
    public int GetExperience(int exp)
    {
        return experience;

    }
    
}
