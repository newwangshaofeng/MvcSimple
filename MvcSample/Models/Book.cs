using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{
   
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }


    }
}