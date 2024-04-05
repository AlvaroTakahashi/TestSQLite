using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsApp1.Class
{
    public class Conexion
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        
            private static Conexion _instanci = null;

        public Conexion()
        {
           
        }

        public static Conexion Instancia
        {
            get
            {
                if (_instanci == null)
                {
                    _instanci = new Conexion();
                }
                return _instanci;
            }
        }


    }
}
