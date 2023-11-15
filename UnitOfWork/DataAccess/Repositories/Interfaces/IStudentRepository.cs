using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student Get(Guid id);
        void Create(Student item);
        void Update(Student item);
        void Delete(Guid id);
    }
}
