using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class Empresas
    {
        string Nombre,Direccion,Email;
         int   Telefono;
        
        SqlConnection cnx = new SqlConnection("Server=.;Database=Directorio;Integrated Security=true");
        public Empresas datosPersona()
        {

            SqlCommand cmd = new SqlCommand("Empresas", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cnx.Open();
            Empresas e = new Empresas();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                e.Nombre = dr.GetString(0);
                e.Direccion = dr.GetString(2);
                e.Email = dr.GetString(3);
                e.Telefono = dr.GetInt32(4);

            }
            cnx.Close();
            return e;
        }
        public Empresas ListarEmpresas()
        {
            SqlCommand cmd = new SqlCommand("ListarE", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cnx.Open();
            Empresas a = new Empresas();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                a.Nombre = dr.GetString(0);
            }
            cnx.Close();
            return a;
        }
    }
}
