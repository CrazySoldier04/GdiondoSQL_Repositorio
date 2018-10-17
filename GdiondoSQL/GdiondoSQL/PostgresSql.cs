using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace GdiondoSQL
{
    public class PostgresSql
    {
        PostgresSql libp = new PostgresSql();
        public static String errorMsge;
        private bool res = false;

        public PostgresSql(string host, string pwd, string )

        public bool OpenConnection()
        {
            try
            {
                res = libp.OpenConnection();
            }
            catch (Exception ex)
            {
                errorMsge = "Error al abrir la conexión de Postgres: " + ex.ToString();
            }
            return res;
        }
    }
}