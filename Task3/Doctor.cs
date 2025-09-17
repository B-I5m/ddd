using System;
using System.Runtime.CompilerServices;

namespace Task3;

public class Doctor
{
    string fullname;
    string specialty;
    int experience;
    public Doctor(string fullName, string specialty, int experience)
    {
        this.fullname = fullName;
        this.specialty = specialty;
        this.experience = experience;
     }
     
    public string TreatPatient(Patient patient)
    {
        return $"{fullname},{specialty},лечит пациента {patient.FullName}";
    }
    public string PerformMedicalExamination(Patient patient)
    {
        return $"{fullname}, проводит медицинское обследование для пациента {patient.FullName}";
    }
    public string PrescribeMedication(Patient patient, string medication)
    {
        return $"{fullname} назначает {medication} пациенту {patient.FullName}";
    }
    public void SetExperience(int years)
    {
        experience = years;
    }
    public int GetExperience()
    {
        return experience;
     }
     }
