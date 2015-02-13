using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using MySqlDAL;
using MySql.Data.MySqlClient;
namespace BLL
{
    public class News
    {
        public int add(Model.News mn)
        {
            NewsDAL dn = new NewsDAL();
            int result = dn.add(mn);
            return result;
        }
        public int _delete(Model.News mn)
        { 
            NewsDAL dn=new NewsDAL();
            int result = dn._delete(mn);
            return result;
        }
        public MySqlDataReader datareader(Model.News mn)
        {
            NewsDAL dn = new NewsDAL();
            MySqlDataReader sdr = dn.datareader(mn);
            return sdr;
        }
        public int update(Model.News mn)
        {
            NewsDAL dn = new NewsDAL();
            int result = dn.update(mn);
            return result;
        }
    }  
}
