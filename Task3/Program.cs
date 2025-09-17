using Task3;

Patient patient = new Patient("Иван Иванов", 30);
Doctor doctor = new Doctor("Др. Смирнов", "Терапевт", 5);
Console.WriteLine(doctor.TreatPatient(patient));
Console.WriteLine(doctor.PerformMedicalExamination(patient));
Console.WriteLine(doctor.PrescribeMedication(patient, "Антибиотики"));
doctor.SetExperience(10);
Console.WriteLine($"Опыт врача: {doctor.GetExperience()} лет");
System.Console.WriteLine(patient.GetFullName());
System.Console.WriteLine(patient.AddMedicalRecord("Диагноз: Простуда"));