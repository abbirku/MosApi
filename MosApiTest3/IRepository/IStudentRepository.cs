using MosApiTest3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosApiTest3.IRepository
{
    public interface IStudentRepository
    {
        Student Get(long id);
        IEnumerable<Student> GetAll();
        Student Post(Student student);
        Student Update(Student student);
        Student Delete(long id);
    }
}
