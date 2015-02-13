using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;

namespace BLL
{
    public   class BLLorderselect
    {
        public int pageint()
        {
            DALorderselectDAL dall = new DALorderselectDAL();
            return dall.pageint();
        }
        public int pageint1(Model .order myorder)
        {
            DALorderselectDAL dall = new DALorderselectDAL();
            return dall.pageint1(myorder );
        }
        public DataSet pagebind(int a, int b)
        {
            DALorderselectDAL dall = new DALorderselectDAL();
            return dall.pagebind(a, b);
        }
        public DataSet pagebind1(int a, int b,Model .order myorder)
        {
            DALorderselectDAL dall = new DALorderselectDAL();
            return dall.pagebind1(a, b,myorder );
        }
        public int delete(Model.order myorder)
        {
            DALorderselectDAL dall = new DALorderselectDAL();
            return dall.delete(myorder);
        }
  
    }
}
