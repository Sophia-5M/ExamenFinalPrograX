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
    public class taxService : ITax
    {
        public void DeleteTax(int id)
        {
            throw new NotImplementedException();
        }

        public List<tbl_taxModel> EditTax(IDbConnection dbConnection, int id_tax)
        {
            throw new NotImplementedException();
        }

        public tbl_taxModel GetTax()
        {
            throw new NotImplementedException();
        }

        public List<tbl_taxModel> GetTax(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetTax(tbl_taxModel tax)
        {
            throw new NotImplementedException();
        }
    }
}
