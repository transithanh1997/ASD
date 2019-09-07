using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjModel
{
    [Table("Recipes")]
    public class Recipes
    {

        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(250)]    
        public string Title {get;set;}
        [Column(TypeName = "nvarchar")]
        public string Content { get; set; }
        public int WriterID { get; set; }
        public virtual Writer Writer { set; get; }

    }
}
