using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class StudentService
    {
        private static readonly AppDbContext _context = new AppDbContext();

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void Create(Student student)
        {
          
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
         
            var studentToDelete = _context.Students.FirstOrDefault(s => s.Id == id);

        }
    }
}
