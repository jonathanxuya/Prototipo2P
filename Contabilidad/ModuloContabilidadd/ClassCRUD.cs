using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace CapaVista
{
    class ClassCRUD
    {
        public bool InsertProducto(string _a, string _b, string _c, string _d, string _e, string _f, string _g)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Contabilidad"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_PolizasLocales (pk_PolizasLocales,emision,concepto,detalle,totalcargo,totalbono,diferencia)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_PolizasLocales", OdbcType.Int).Value = _a;
                    cmd.Parameters.Add("@emision", OdbcType.VarChar).Value = _b;
                    cmd.Parameters.Add("@concepto", OdbcType.VarChar).Value = _c;
                    cmd.Parameters.Add("@detalle", OdbcType.VarChar).Value = _d;
                    cmd.Parameters.Add("@totalcargo", OdbcType.VarChar).Value = _e;
                    cmd.Parameters.Add("@totalbono", OdbcType.VarChar).Value = _f;
                    cmd.Parameters.Add("@diferencia", OdbcType.VarChar).Value = _g;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool updateproduct (string _a, string _b, string _c, string _d, string _e, string _f, string _g)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Contabilidad"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_PolizasLocales SET tbl_PolizasLocales.concepto = ?, tbl_PolizasLocales.detalle = ?, tbl_PolizasLocales.totalcargo = ?, tbl_PolizasLocales.totalbono = ?, tbl_PolizasLocales.diferencia = ?WHERE tbl_PolizasLocales.emision = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_PolizasLocales", OdbcType.Int).Value = _a;
                    cmd.Parameters.Add("@emision", OdbcType.VarChar).Value = _b;
                    cmd.Parameters.Add("@concepto", OdbcType.VarChar).Value = _c;
                    cmd.Parameters.Add("@detalle", OdbcType.VarChar).Value = _d;
                    cmd.Parameters.Add("@totalcargo", OdbcType.VarChar).Value = _e;
                    cmd.Parameters.Add("@totalbono", OdbcType.VarChar).Value = _f;
                    cmd.Parameters.Add("@diferencia", OdbcType.VarChar).Value = _g;
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteProducto(string _b)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Contabilidad"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_PolizasLocales WHERE tbl_PolizasLocales.emision = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@emision", OdbcType.VarChar).Value = _b;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable SelectProducto()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM producto;", "FIL=MS Access;DSN=Contabilidad"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
