using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Interfaces_ProyectoFinal
{
   public class conexion
    {
        public static MySqlConnection obteniendoConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=intertech;Uid=root;pwd=PabloG2017");
            conexion.Open();
            return conexion;
        }

    }

}
