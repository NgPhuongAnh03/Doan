using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Connect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=WIBU\SQLEXPRESS;Initial Catalog=DOAN1;Integrated Security=True");
    }
}
