using System;

namespace EF
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }

 

           
            studentService.Create(new Student { Name = "Vagif", Surname = "Garayev", AvgPoint = 80 });
            studentService.Create(new Student { Name = "Mata", Surname = "Adigozelova", AvgPoint = 95 });

           
            Console.WriteLine("Telebeler :");
            var allStudents = studentService.GetAll();
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.Id}. {student.Name} {student.Surname}, Avg Point: {student.AvgPoint}");
            }

            
            int studentIdToFind = 1;
            var foundStudent = studentService.GetById(studentIdToFind);

            if (foundStudent != null)
            {
                Console.WriteLine($"\nStudent  Id {studentIdToFind}: {foundStudent.Name} {foundStudent.Surname}, Avg Point: {foundStudent.AvgPoint}");
            }
            else
            {
                Console.WriteLine($"\nStudent  Id {studentIdToFind} not found.");
            }


            int studentIdToDelete = 2;
            studentService.Delete(studentIdToDelete);
            Console.WriteLine($"\nStudent  Id {studentIdToDelete} delete.");

          
            Console.WriteLine("\nRemain Students:");
            var remainingStudents = studentService.GetAll();
            foreach (var student in remainingStudents)
            {
                Console.WriteLine($"{student.Id}. {student.Name} {student.Surname}, Avg Point: {student.AvgPoint}");
            }
        }
    }
}