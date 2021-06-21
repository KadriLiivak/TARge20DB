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

    public class haiguslehed
    {
        [Key]
        public Guid haigusleheId { get; set; }
        public tootaja tootaja { get; set; }
        public haigusleheTyyp haigusleheTyyp { get; set; }

        public DateTime haigusleheAlgus { get; set; }
        public DateTime haigusleheLopp { get; set; }
        public string kommentaar { get; set; }

        //public ICollection<haigusleheTyyp> haigusleheTyyps { get; set; }
        //public ICollection<tootaja> tootajas { get; set; }
    }
}
