using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GdiondoSQL
{
    class MySql
    {
        public String errorMsge;
        public static List<String> lista = new List<string>();
        public static List<String> listaTablas;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection cn;
        private bool res = false;
        DataTable dt;
        MySqlDataAdapter da;
        //DataSet dt

        public MySql(string host, string puerto, string usuario, string pwd, string database)
        {
            cn = new MySqlConnection("server=" + host + ";port=" + puerto + ";uid=" + usuario + ";pwd=" + pwd + ";database=" + database + ";");
        }

        public MySql()
        {

        }

        public bool AbrirConexion()
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                    res = true;
                }
                else
                {
                    errorMsge = "La conexión ya está abierta";
                }
            }
            catch (MySqlException mysqlex)
            {
                errorMsge = "Error de Mysql al abrir la conexión: " + mysqlex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al abrir la conexión: " + ex.ToString();
            }
            return res;
        }

        public bool CerrarConexion()
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    res = true;
                }
            }
            catch (MySqlException mysqlex)
            {
                errorMsge = "Error de MySql al cerrar la conexión: " + mysqlex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al cerrar la conexión: " + ex.ToString();
            }
            return res;
        }

        public object Databases()
        {
            try
            {
                if (AbrirConexion())
                {
                    cmd = new MySqlCommand("SHOW DATABASES;", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        while (dr.Read())
                        {
                            lista.Add(dr.GetString(0));
                        }
                    }
                }
            }
            catch (MySqlException mysqlex)
            {
                errorMsge = "Error de MySql al consultar las bases de datos: " + mysqlex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general: " + ex.ToString();
            }
            finally
            {
                CerrarConexion();
            }
            return lista;
        }

        public object Tables(string database)
        {
            try
            {
                if (AbrirConexion())
                {
                     listaTablas = new List<string>();
                    cmd = new MySqlCommand("USE " + database + ";", cn);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("SHOW TABLES;", cn);
                    cmd.ExecuteNonQuery();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        while (dr.Read())
                        {
                            listaTablas.Add(dr.GetString(0));
                        }
                    }
                }
            }
            catch (MySqlException mysqlex)
            {
                errorMsge = ("Error en la base de datos al consultar las tablas: " + mysqlex.ToString());
            }
            catch (Exception ex)
            {
                errorMsge = ("Error general al consultar las tablas: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
            return listaTablas;
        }

        public DataTable TodosLosCampos(String tabla)
        {
            try
            {
                dt = new DataTable();
                if (AbrirConexion())
                {
                    da = new MySqlDataAdapter("SELECT * FROM " + tabla + ";", cn);
                    da.Fill(dt);
                }
            }
            catch (MySqlException mysqlex)
            {
                errorMsge = "Error de MySql al consultar los datos de la tabla: " + mysqlex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general: " + ex.ToString();
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }

        public string ShowCreateTable(String tabla)
        {
            try
            {
                if(AbrirConexion())
                {
                    cmd = new MySqlCommand("SHOW CREATE TABLE " + tabla + ";", cn);
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        dr.GetString(1);
                    }
                }

            }
            catch (MySqlException mysqlex)
            {
                errorMsge = "Error de MySql al mostrar la estructura de la tabla: " + mysqlex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general al mostrar la estructura de la tabla: " + ex.ToString();
            }
            finally
            {
                CerrarConexion();
            }
            return "";
        }
    }
}