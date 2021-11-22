using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace COIN6
{
    class ConexionSQL
    {
        string CadenaConexion = "Data Source = LESLIE\\SQLEXPRESS; Initial Catalog = COIN6; Integrated Security = TRUE";
        public SqlConnection conectar = new SqlConnection();

        public ConexionSQL()
        {
            conectar.ConnectionString = CadenaConexion;
        }

        public void Abrir()
        {
            try 
            {
                conectar.Open();
                Console.WriteLine("Conectado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al conectar " + e.Message);
            }
        }

        public void Cerrar()
        {
            conectar.Close();
        }
    }
}
