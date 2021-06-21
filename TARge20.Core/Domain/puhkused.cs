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
    public class puhkused
    {
        [Key]
        public Guid puhkuseId { get; set; }
        public tootaja tootaja { get; set; }
        public puhkuseTyyp puhkuseTyyp { get; set; }

        public DateTime puhkuseAlgus { get; set; }
        public DateTime puhkuseLopp{ get; set; }
        public string kommentaar { get; set; }

        //public ICollection<tootaja> tootajas { get; set; }
        //public ICollection<puhkuseTyyp> puhkuseTyyps { get; set; }
    }
}