using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjModel
{
    [Table("writer")]
    public class Writer
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName="nvarchar")]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Recipes> Recipes { set; get; }

    }
}
