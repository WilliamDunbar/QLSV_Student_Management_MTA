using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVWF
{
     class Model
     {
          string strconnect = @"Data Source=DESKTOP-C3373F2;Initial Catalog=QL_SinhVien;Integrated Security=True";

          
          public SqlConnection getConnect()
          {
               return new SqlConnection(strconnect);
          }

          
     }
}
