using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [StringLength(100)]
        public string BlogName { get; set; }

        [StringLength(300)]
        public string BlogImage { get; set; }

        public DateTime BlogDate { get; set; }

        //Content çok uzun olabileceği için herhangi bir kısıt koymadık.
        public string BlogContent { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
