using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public  class adminuser
    {
        public DataSet dsus(int a, int b, string c)

        {
            adminuserDAL dalad = new adminuserDAL();
            return dalad.dsuser(a,b,c);
        }
        public int count()
        {
            adminuserDAL dal = new adminuserDAL();
            return dal.count();
        }
        public int dele(Model.user aa)
        {
            adminuserDAL da = new adminuserDAL();
            return da.dele(aa);
        }
        public int coun(Model.user aa)
        {
            adminuserDAL das = new adminuserDAL();
            return das.cou(aa);
        }
        public DataSet seu(int a, int b, string c, Model.user aa)
        {
            adminuserDAL dad = new adminuserDAL();
            return dad.dsu(a,b,c,aa);
        }
        public MySqlDataReader drus(Model.user aa)
        {
            adminuserDAL dal = new adminuserDAL();
            return dal.drus(aa);
        }
    }
}
