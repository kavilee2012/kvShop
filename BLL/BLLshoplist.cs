using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
     public  class BLLshoplist
    {
        public MySqlDataReader readpro(Model.product  myorder)
        {
            DALshoplist2DAL dall = new DALshoplist2DAL();
            return dall.readpro(myorder);
        }
    }
}
