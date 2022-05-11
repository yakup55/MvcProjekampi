using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
   public class About //HAKKIMDA
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(1000)]
        public string AboutDetails1 { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string Aboutİmage1 { get; set; }
        [StringLength(100)]
        public string Aboutİmage2 { get; set; }
       



    }
}
