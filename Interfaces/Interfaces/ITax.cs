using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ITax
    {
        tbl_taxModel GetTax();
        List<tbl_taxModel> GetTaxes(System.Data.IDbConnection dbConnection);
        void SetTax(tbl_taxModel tax);
        void DeleteTax(int id);
        List<tbl_taxModel> EditTax(System.Data.IDbConnection dbConnection, int id_tax);
    }
}
