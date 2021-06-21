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

    public class puhkuseTyyp
    {
        [Key]
        public Guid puhkuseTyypId { get; set; }


        public string nimetus { get; set; }
        public string kommentaar { get; set; }

        //public ICollection<puhkused> puhkused { get; set; }
    }
}