using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MosApiTest3.Models
{
    [Table("Students")]
    public class Student
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}