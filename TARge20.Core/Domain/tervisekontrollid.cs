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
    public class tervisekontrollid
    {
        [Key]
        public Guid tervisekontrolliId { get; set; }
        public tootaja tootaja { get; set; }

        public DateTime kuupäev { get; set; }
        public DateTime kellaaeg { get; set; }
        public string tulemus { get; set; }
        public string kommentaar { get; set; }

        //public ICollection<tootaja> tootajas { get; set; }
    }
}