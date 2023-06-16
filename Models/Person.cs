using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Event Code")]
        public int CusId { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [DisplayName("Firt Name")]
        public string  Fname { get; set; }
        [DisplayName("Contact Number")]
        public string ContactNo { get; set; }
        public DateTime Date { get; set; }
        [DisplayName("Person's age")]
        public int Age { get; set; }


    }
}