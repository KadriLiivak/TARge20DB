using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{

    public class haigusleheTyyp
    {
        [Key]
        public Guid haigusleheTyypId { get; set; }
        
        public string nimetus { get; set; }
        public string kommentaar { get; set; }

        public ICollection<haiguslehed> haiguslehed { get; set; }
            }
}