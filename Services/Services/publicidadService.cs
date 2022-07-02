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
    public class publicidadService : IPublicidad
    {
        public void DeletePublicidad(int id)
        {
            throw new NotImplementedException();
        }

        public List<tbl_publicidadModel> EditPublicidad(IDbConnection dbConnection, int id_publicidad)
        {
            throw new NotImplementedException();
        }

        public tbl_publicidadModel GetPublicidad()
        {
            throw new NotImplementedException();
        }

        public List<tbl_publicidadModel> GetPublicidad(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetPublicidad(tbl_publicidadModel publicidad)
        {
            throw new NotImplementedException();
        }
    }
}
