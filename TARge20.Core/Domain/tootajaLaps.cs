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
        public class tootajaLaps
        {
            [Key]
            public Guid tootajaLapsId { get; set; }
            public tootaja tootaja { get; set; }

            public string eesnimi { get; set; }
            public string perekonnanimi { get; set; }
            public int isikukood { get; set; }
            public string kommentaar { get; set; }
            public string kontaktaadress { get; set; }
            public int kontakttelefon { get; set; }
            public string kontaktEmail { get; set; }
      
        
        
        }
    }



