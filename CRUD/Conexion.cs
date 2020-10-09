using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            //string servidor = "127.0.0.1";
            //string bd = "tienda";
            //string usuario = "root";
            //string password = "";

            //Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario + "; Password=" + password+"";
            //string cadenaConexion = "SERVER=db4free.net;PORT=3306;DATABASE=dbjose;UID=josecid;PWD=Desiree123;";
            string cadenaConexion = "SERVER=remotemysql.com;PORT=3306;DATABASE=5oZvBu9Tgh;UID=5oZvBu9Tgh;PWD=U9lz5KygNt;";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
