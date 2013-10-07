using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class Personas
    {
        string Nombre,Apellidos,Direccion,Email;
         int   Telefono;
         DateTime Cumpleaños;
        SqlConnection cnx = new SqlConnection("Server=.;Database=Directorio;Integrated Security=true");
        public List<Personas> datosPersona()
        {
            
            SqlCommand cmd = new SqlCommand("Personas", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cnx.Open();
            List<Personas> rpta = new List<Personas>();
            Personas a = new Personas();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                a.Nombre=dr.GetString(0);
                a.Apellidos=dr.GetString(1);
                a.Telefono = dr.GetInt32(2);
                a.Direccion=dr.GetString(3);
                a.Email=dr.GetString(4);
                a.Cumpleaños=dr.GetDateTime(5);
                rpta.Add(a);
            }
            cnx.Close();
            return rpta;
        }
        public List<Personas> ListarPersonas()
        {
            SqlCommand cmd = new SqlCommand("ListarP", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            List<Personas> rpta =new List<Personas>();
            Personas a = new Personas();
            SqlDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                a.Nombre=dr.GetString(0);
                rpta.Add(a);
            }
            cnx.Close();
            return rpta;
        }

    }
}
