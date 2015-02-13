using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySqlDAL;
using MySql.Data.MySqlClient;

namespace BLL
{
  public   class BLLorderupdate
    {
        public MySqlDataReader readorder(Model.order myorder)
        {
            DALorderupdateDAL dall = new DALorderupdateDAL();
            return dall.readorder(myorder);
        }
        public int update(Model.order myorder)
        {
            DALorderupdateDAL dall = new DALorderupdateDAL();
            return dall.update(myorder);
        }
        public DataSet bindgr(Model .orderdetail myorderdetail)
        {
            DALorderupdateDAL dall = new DALorderupdateDAL();
            return dall.bindgr(myorderdetail );
        }
    }
}
