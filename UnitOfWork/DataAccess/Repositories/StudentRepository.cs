using DataAccess.Context;
using DataAccess.Models;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UnitOfWorkContext context;

        public StudentRepository(UnitOfWorkContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return context.Students;
        }

        public Student Get(Guid id)
        {
            return context.Students.Find(id);
        }

        public void Create(Student student)
        {
            var lol = context.Students.Add(student);
            int i = 0;
        }

        public void Update(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            Student student = context.Students.Find(id);
            if (student != null)
                context.Students.Remove(student);
        }
    }
}
