using Autofac;
using Interfaces.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalPX
{
    public class DIModule : Autofac.Module
    {
        string connectionString = @"Server=localhost;Initial Catalog=EFPrograX;Trusted_Connection=true";

        protected override void Load(ContainerBuilder builder)
        {
            SqlConnection conn;
            #region Caja Chica
            builder.RegisterType<cajaService>().As<ICaja>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Gastos
            builder.RegisterType<gastoService>().As<IGasto>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Publicidad
            builder.RegisterType<publicidadService>().As<IPublicidad>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Impuestos
            builder.RegisterType<taxService>().As<ITax>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
        }
    }
}
