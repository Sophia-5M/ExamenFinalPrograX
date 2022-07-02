using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class tbl_gastoModel
    {
        public int id_gasto { get; set; }
        public string descripcion { get; set; }
        public float total { get; set; }
        public string estado { get; set; }
    }
}
