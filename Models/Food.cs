using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication3.Models
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodId { get; set; }
        public int CusId { get; set; }
        public  bool Pizza { get; set; }
        public  bool Pasta { get; set; }
        public bool PapWors { get; set; }
        public bool  { get; set; }
        public bool PapWors { get; set; }



    }
}