using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IGasto
    {
        tbl_gastoModel GetGasto();
        List<tbl_gastoModel> GetGastos(System.Data.IDbConnection dbConnection);
        void SetGasto(tbl_gastoModel gasto);
        void DeleteGasto(int id);
        List<tbl_gastoModel> EditGasto(System.Data.IDbConnection dbConnection, int id_gasto);
    }
}
