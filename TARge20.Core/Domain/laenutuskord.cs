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
    public class laenutuskord
    {

        [Key]
        public Guid laenutuskordId { get; set; }
        public tootaja tootaja { get; set; }
        public laenutatavEse laenutatavEse { get; set; }

        public DateTime laenutuseAlgus { get; set; }
        public DateTime laenutuseLopp { get; set; }

        //public ICollection<tootaja> tootajas { get; set; }
        //public ICollection<laenutatavEse> laenutatavEses { get; set; }
    }
}