using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class tbl_taxModel
    {
        public int id_tax { get; set; }
        public float iva { get; set; }
        public float isr { get; set; }
        public float total { get; set; }
        public string estado { get; set; }

    }
}
