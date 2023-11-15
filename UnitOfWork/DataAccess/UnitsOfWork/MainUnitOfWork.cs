using DataAccess.Context;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitsOfWork
{
    public class MainUnitOfWork : IUnitOfWork
    {
        private readonly UnitOfWorkContext context;
        private IStudentRepository studentRepository;
        public MainUnitOfWork(UnitOfWorkContext context)
        {
            this.context = context;
        }

        public IStudentRepository StudentRepository 
        {
            get {
                return studentRepository = studentRepository ?? new StudentRepository(context);
            }
            set => throw new NotImplementedException(); 
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
