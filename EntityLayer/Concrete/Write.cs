using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Write
    {
        [Key]
        public int WriteID { get; set; }
        [StringLength(50)]
        public string WriteName { get; set; }
        [StringLength(50)]
        public string WriteSurName { get; set; }
        [StringLength(100)]
        public string WriteImage { get; set; }
        [StringLength(50)]
        public string WriteMail { get; set; }
        [StringLength(50)]
        public string WritePassword { get; set; }

        public ICollection<Heading> Headings { get; set; }
       public ICollection<Content>Contents { get; set; }


    }
}
