using MosApiTest3.IRepository;
using MosApiTest3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MosApiTest3.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public IHttpActionResult Get(long id)
        {
            try
            {
                var result = studentRepository.Get(id);
                if (result != null)
                    return Ok(new { success = true, data = result });
                else
                    return Ok(new { success = false });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                var result = studentRepository.GetAll();

                return Ok(new { success = true, dataList = result });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Student student)
        {
            try
            {
                var result = studentRepository.Post(student);

                return Ok(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }

        [HttpPut]
        public IHttpActionResult Update(Student student)
        {
            try
            {
                var result = studentRepository.Update(student);
                if (result != null)
                    return Ok(new { success = true, data = result });
                else
                    return Ok(new { success = false });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(long id)
        {
            try
            {
                var result = studentRepository.Delete(id);
                if (result != null)
                    return Ok(new { success = true, data = result });
                else
                    return Ok(new { success = false });
            }
            catch (Exception ex)
            {
                return Ok(new { success = false, errorMessage = ex.Message });
            }
        }
    }
}
