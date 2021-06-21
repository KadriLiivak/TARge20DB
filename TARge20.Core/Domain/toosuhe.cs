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
    public class toosuhe
    {
        [Key]
        public Guid toosuheId { get; set; }
        public tootaja tootaja { get; set; }
        public ametinimetused ametinimetused { get; set; }
        
        public DateTime toolAlates { get; set; }
        public DateTime toolKuni { get; set; }
        public string koormus { get; set; }

        //public ICollection<tootaja> tootajas { get; set; }
        //public ICollection<ametinimetused> ametinimetuseds { get; set; }





    }
}
