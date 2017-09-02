using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoDeIdiomas
{
    class MsSqlConnection
    {
       public  static string server = InstitutoDeIdiomas.Properties.Settings.Default.ServerName;
       public static string db = InstitutoDeIdiomas.Properties.Settings.Default.DB;
       public  static string user = InstitutoDeIdiomas.Properties.Settings.Default.User; 
       public  static string pass = InstitutoDeIdiomas.Properties.Settings.Default.Password; 
       public  string _ConnectionString = String.Format("Data Source={0}; Initial Catalog={1}; Persist Security Info=True; User Id={2}; Password={3}", server, db, user, pass);

       
    }
}
