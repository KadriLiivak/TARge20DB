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
    public class vihjed
    {
        [Key]
        public Guid vihjeId { get; set; }
        public tootaja tootaja { get; set; }
        public  DateTime kuupaev { get; set; }
        public string kommentaar { get; set; }

        //public ICollection<tootaja> tootajas { get; set; }

    }
}