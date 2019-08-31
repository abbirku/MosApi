using MosApiTest3.IRepository;
using MosApiTest3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MosApiTest3.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DatabaseContext context;

        public StudentRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public Student Get(long id)
        {
            return context.Student.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Student> GetAll()
        {
            return context.Student.ToList();
        }

        public Student Post(Student student)
        {
            var result = context.Student.Add(student);
            context.SaveChanges();
            return result;
        }

        public Student Update(Student student)
        {
            var data = context.Student.Where(x => x.Id == student.Id).FirstOrDefault();
            if (data != null)
            {
                context.Student.AddOrUpdate(student);
                context.SaveChanges();
                return student;
            }
            else
                return null;
        }

        public Student Delete(long id)
        {
            var model = context.Student.Where(x => x.Id == id).FirstOrDefault();
            if (model != null)
            {
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
            return model;
        }
    }
}