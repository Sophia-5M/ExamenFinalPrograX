using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ICaja
    {
        tbl_cajaModel GetCaja();
        List<tbl_cajaModel> GetCajas(System.Data.IDbConnection dbConnection);
        void SetCaja(tbl_cajaModel caja);
        void DeleteCaja(int id);
        List<tbl_cajaModel> EditCaja(System.Data.IDbConnection dbConnection, int id_caja);
    }
}
