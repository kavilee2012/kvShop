using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using MySqlDAL;

namespace BLL
{
   public  class bllhhh
    {
        public int insert(Model .admin ad)
        {
            DALadminDAL dalhh = new DALadminDAL();
            return dalhh.hh (ad);
        }
    }
}
