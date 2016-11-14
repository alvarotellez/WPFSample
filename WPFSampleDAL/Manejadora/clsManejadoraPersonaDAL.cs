using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample_DAL;
using WPFSampleEntities;

namespace WPFSampleDAL.Manejadora
{
    public class clsManejadoraPersonaDAL
    {

        private clsMyConnection miConexion;
        public clsManejadoraPersonaDAL()
        {
            miConexion = new clsMyConnection();
        }
        public int insertarPersonaDAL(clsPersona persona)
        {
            int resultado = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();

            //Añadimos los datos al comando

            miComando.Parameters.Add("@nombre",System.Data.SqlDbType.VarChar).Value=persona.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
            miComando.Parameters.Add("@fechaNac", System.Data.SqlDbType.Date).Value = persona.FechaNac;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;

            try
            {
                conexion = miConexion.getConnection();
                miComando.CommandText = "INSERT INTO PERSONAS(nombre,apellidos,fechaNac,direccion,telefono) VALUES (@nombre, @apellidos, @fechaNac, @direccion,@telefono)";
                miComando.Connection = conexion;
                //Resultado es el numero de personas afectadas
                resultado = miComando.ExecuteNonQuery();


                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }
        }
        /// <summary>
        /// El metodo getPersonaDAL nos sirve para ver los detalles y lo usaremos a la hora de actualizar la persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>Un entero que identifica la persona</returns>
        /*public int getPersonaDAL(clsPersona persona)
        {

        }*/
        /// <summary>
        /// El metodo updatePersonaDAL actualiza los datos de una persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int updatePersonaDAL(clsPersona persona)
        {
            int resultado = 0;

            SqlConnection conexion = new SqlConnection();
            SqlCommand miComando = new SqlCommand();
            //Añadimos los datos del comando
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = persona.Id;
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
            miComando.Parameters.Add("@fechaNac", System.Data.SqlDbType.Date).Value = persona.FechaNac;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.Direccion;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.Telefono;
            try
            {
                conexion = miConexion.getConnection();
                miComando.CommandText = "UPDATE PERSONAS SET nombre=@nombre,apellidos=@apellidos,fechaNac=@fechaNac,direccion=@direccion,telefono=@telefono";
                miComando.Connection = conexion;
                //Resultado es el numero de personas afectadas
                resultado = miComando.ExecuteNonQuery();


                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
                miConexion.closeConnection(ref conexion);
            }
        }
        /// <summary>
        /// El metodo deletePersonaDAL elimina a una persona
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        /*public int deletePersonaDAL(clsPersona persona)
        {

        }*/

    }

}
