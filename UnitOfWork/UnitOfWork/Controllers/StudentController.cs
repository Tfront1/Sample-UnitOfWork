using DataAccess.Models;
using DataAccess.UnitsOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UnitOfWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public Student GetById(Guid id)
        {
            return unitOfWork.StudentRepository.Get(id);
        }

        [HttpPost]
        public void Create(Student student)
        {
            student.Id = Guid.NewGuid();
            unitOfWork.StudentRepository.Create(student);
        }

        [HttpPut]
        public void Update(Student student)
        {
            unitOfWork.StudentRepository.Update(student);
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            unitOfWork.StudentRepository.Delete(id);
        }

        [HttpGet("GetAll")]
        public IEnumerable<Student> GetAll()
        {
            return unitOfWork.StudentRepository.GetAll();
        }
    }
}