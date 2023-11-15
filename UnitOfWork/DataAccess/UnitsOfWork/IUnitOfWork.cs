using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitsOfWork
{
    public interface IUnitOfWork
    {
        public IStudentRepository StudentRepository { get;set;}

        void Save();
    }
}
