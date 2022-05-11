﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
  public class Heading //BAŞLIK
    {
        //prop TAB TAB
        [Key]
        public int HeadingID { get; set; } //VERİ TABANINA YANSICAK
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //İLİŞKİ
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int WriterID  { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
