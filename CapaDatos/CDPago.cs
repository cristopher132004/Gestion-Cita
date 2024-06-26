﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatos
{
    public class CDPago
    {
        private int dIdPago, dIdCita;
        private String dConceptoPago, dEstado;

        public CDPago() { }
        public CDPago(int pIdPago, int pIdCita, string pConceptoPago, string pEstado)
        {
            this.dIdPago = pIdPago;
            this.dIdCita = pIdCita;
            this.dConceptoPago = pConceptoPago;
            this.dEstado = pEstado;
        }
        public int IdPago
        {
            get { return dIdPago; }
            set { dIdPago = value; }
        }


        public int IdCita
        {
            get { return dIdCita; }
            set { dIdCita = value; }
        }

        public string ConceptoPago
        {
            get { return dConceptoPago; }
            set { dConceptoPago = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        public string Insertar(CDPago objPago)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = ConexionDB.miconexion;
                //Escribo el nombre del procedimiento almacenado que utilizaré, en este caso BarberoInsertar
                SqlCommand micomando = new SqlCommand("PagoInsertar", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIdCita", objPago.IdCita);
                micomando.Parameters.AddWithValue("@pConceptoPago", objPago.ConceptoPago);
                micomando.Parameters.AddWithValue("@pEstado", objPago.Estado);
                //Metodo Insertar
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos insertados correctamente!" :
                                                             "No se pudo insertar correctamente los datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;

        }//Metodo
         //método para actualizar los datos del Barbero. Recibirá el objeto objBarbero como parámetro
        public string Actualizar(CDPago objPago)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = ConexionDB.miconexion;
                SqlCommand micomando = new SqlCommand("PagoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIdPago", objPago.IdPago);
                micomando.Parameters.AddWithValue("@pIdCita", objPago.IdCita);
                micomando.Parameters.AddWithValue("@pConceptoPago", objPago.ConceptoPago);
                micomando.Parameters.AddWithValue("@pEstado", objPago.Estado);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
                 "No se pudo actualizar correctamente los datos!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return mensaje;
        }

        //Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable PagoConsultar(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Barberos
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new ConexionDB().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "PagoConsultar"; //Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex)
            {
                dt = null; //Si ocurre algun error se anula el DataTable
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método MostrarConFiltro


    }
}//Fin de la clase CDCliente