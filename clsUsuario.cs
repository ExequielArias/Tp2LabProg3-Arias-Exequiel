using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Windows.Forms; 

namespace pryInicioSesionLogs
{
    internal class clsUsuario
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDS;
        DataTable tabla; 

        string rutaArchivo;
        public string estadoConexion;

        public clsUsuario()
        {
            try
            {
                rutaArchivo = @"../../Archivos/BDusuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "Conectado";

                comandoBD.CommandText = "Nombre";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public void RegistroLogInicioSesion(TextBox usuario, TextBox contra, ComboBox area)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS,"Logs");
                estadoConexion = "Registro exitoso de log";
                
                
                bool ok = true;
                DataRow filaBuscar = tabla.Rows.Find(usuario);
                if (filaBuscar == null)
                {
                    foreach (DataRow fusua in tabla.Rows)
                    {
                        if (fusua["nombre"].ToString() == usuario.Text) 
                        {
                            ok = false;
                        }
                    }
                    if (ok == true)
                    {
                        DataRow fila = tabla.NewRow();
                        fila["Nombre"] = usuario;
                        fila["Contraseña"] = contra;
                        fila["Perfil"] = area; 
                        tabla.Rows.Add(fila);
                        OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptadorBD);
                        adaptadorBD.Update(tabla);
                    }

                    ok = true;
                }

            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }

        }

        public void ValidarUsuario(string nombreUser, string passUser)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuario";

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() ==nombreUser && lectorBD[2].ToString() == passUser)
                        {
                            estadoConexion = "Usuario EXISTE";
                        }
                    }
                }
                                
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }
        }
        public DataTable getData() 
        {
            return tabla; 
        }



    }
}
