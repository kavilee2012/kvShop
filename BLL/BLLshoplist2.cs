using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
   public  class BLLshoplist2
    {
        public int insert(Model.order myorder)
        {
            DALshoplist2DAL dall = new DALshoplist2DAL();
            return dall.insert(myorder);
      
        }
        public int insertdetail(Model.orderdetail  myorderdetail)
        {
            DALshoplist2DAL dall = new DALshoplist2DAL();
            return dall.insertdetail(myorderdetail);

        }
        public  MySqlDataReader  readaddress(Model.address myaddress)
        {
            DALshoplist2DAL dall = new DALshoplist2DAL ();
            return dall.readaddress(myaddress);

        }
    }
}
