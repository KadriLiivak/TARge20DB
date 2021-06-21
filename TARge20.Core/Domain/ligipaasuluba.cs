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
    public class ligipaasuluba
    {
        [Key]
        public Guid ligipaasulubaId { get; set; }

        public tootaja tootaja { get; set; }
        public ligipaasuloaTyyp ligipaasuloaTyyp { get; set; }

        public DateTime ligipaasuloaAlgus { get; set; }
        public DateTime ligipaasuloaLopp { get; set; }

        //public ICollection<tootaja> tootajas { get; set; }
        //public ICollection<ligipaasuloaTyyp> ligipaasuloaTyyps { get; set; }
    }
}