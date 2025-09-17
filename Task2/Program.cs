using Task2;

Student student = new Student("John Doe", 20, 90);
Console.WriteLine(student.Study());
Console.WriteLine($"Grade: {student.GetGrade()}");