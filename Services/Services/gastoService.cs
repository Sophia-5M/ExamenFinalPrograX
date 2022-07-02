using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class gastoService : IGasto
    {
        public void DeleteGasto(int id)
        {
            throw new NotImplementedException();
        }

        public List<tbl_gastoModel> EditGasto(IDbConnection dbConnection, int id_gasto)
        {
            throw new NotImplementedException();
        }

        public tbl_gastoModel GetGasto()
        {
            throw new NotImplementedException();
        }

        public List<tbl_gastoModel> GetGastos(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetGasto(tbl_gastoModel gasto)
        {
            throw new NotImplementedException();
        }
    }
}
