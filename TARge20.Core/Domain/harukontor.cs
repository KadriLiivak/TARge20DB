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
    public class harukontor
    {
        [Key]
        public Guid harukontorId { get; set; }

        public string aadress { get; set; }
        public int telefoninr { get; set; }
        public string email { get; set; }
       
        public ICollection<tootaja> tootajas { get; set; }
        
    
    }
}
