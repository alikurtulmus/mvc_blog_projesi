﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactSurName { get; set; }

        [StringLength(50)]
        public string ContactMail { get; set; }
        
        [StringLength(50)]
        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
