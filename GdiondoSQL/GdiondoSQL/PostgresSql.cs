using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace GdiondoSQL
{
    public class PostgresSql
    {
        NpgsqlConnection cn;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;
        NpgsqlDataAdapter da;
        DataTable dt;
        public static String errorMsge;
        public List<String> databases = new List<string>();
        public List<String> tables = new List<string>();
        private bool res;
        public String structure;

        public PostgresSql(string host, string user, string pwd, string database)
        {
            string cs = "host=" + host + ";uid=" + user + ";pwd=" + pwd + ";database=" + database + ";";
            cn = new NpgsqlConnection(cs);
        }

        public PostgresSql()
        {
            cn = new NpgsqlConnection("host=127.0.0.1;uid=postgres;pwd=salazar;");
        }

        public bool OpenConnection()
        {
            res = false;
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    res = true;
                }
            }
            catch (NpgsqlException postgresex)
            {
                errorMsge = "Error de Postgres al abrir la conexión: " + postgresex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error al abrir la conexión de Postgres: " + ex.ToString();
            }
            return res;
        }

        public bool CloseConnection()
        {
            res = false;
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Close();
                    res = true;
                }
            }
            catch (NpgsqlException postgresex)
            {
                errorMsge = "Error de postgres al cerrar la conexión: " + postgresex.ToString(); ;
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al cerrar la conexión: " + ex.ToString();
            }
            return res;
        }

        public List<String> Databases()
        {
            try
            {
                if(OpenConnection())
                {
                    cmd = new NpgsqlCommand("SELECT datname FROM pg_database;", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        databases.Add(dr.GetString(0));
                    }
                }
            }
            catch (NpgsqlException postgresex)
            {
                errorMsge = "Error de postres al consultar las bases de datos: " + postgresex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al consultar las bases de datos: " + ex.ToString();
            }
            finally
            {
                CloseConnection();
            }
            return databases;
        }

        public List<String> Tables()
        {
            try
            {
                if (OpenConnection())
                {
                    cmd = new NpgsqlCommand("SHOW TABLES;", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tables.Add(dr.GetString(0));
                    }
                }
            }
            catch (NpgsqlException postgresex)
            {
                errorMsge = "Error de postgres al consultar las tablas: " + postgresex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al consultar las tablas: " + ex.ToString();
            }
            finally
            {
                CloseConnection();
            }
            return tables;
        }

        public DataTable TodosLosCampos(String tabla)
        {
            try
            {
                dt = new DataTable();
                if (OpenConnection())
                {
                    da = new NpgsqlDataAdapter("SELECT * FROM " + tables + ";", cn);
                    da.Fill(dt);
                }
            }
            catch (NpgsqlException postgresex)
            {
                errorMsge = "Error de postgres al consultar los campos: " + postgresex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al consultar los campos: " + ex.ToString();
            }
            finally
            {
                CloseConnection();
            }
            return dt;

        }

        public String ShowCreateTable(String tabla)
        {
            try
            {
                if (OpenConnection())
                {

                }
            }
            catch (NpgsqlException postgresex)
            {
                errorMsge = "Error de postgres al consultar la estructura de la tabla: " + postgresex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al consultar la estructura de la tabla: " + ex.ToString();
            }
            finally
            {
                CloseConnection();
            }
            return structure;
        }
    }
}