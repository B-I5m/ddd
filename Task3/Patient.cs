using System;

namespace Task3;

public class Patient
{
    public string FullName;
    int age;
    List<string> medicalHistory = new List<string>();
    public Patient(string name, int age)
    {
        FullName = name;
        this.age = age;
    }
    public string GetFullName()
    {
        return FullName;
    }
    public string AddMedicalRecord(string record)
    {
        medicalHistory.Add(record);
        return record;
    }
    public List<string> GetMedicalHistory()
    {
        return medicalHistory;
    }
}
