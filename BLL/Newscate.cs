using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySqlDAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class Newscate
    {
        public int insert(Model.Newscate mn)
        {
            NewscateDAL dn = new NewscateDAL();
            int result = dn.insert(mn);
            return result;
        }
        public MySqlDataReader sqldatareader(Model.Newscate mn)
        {

            NewscateDAL dn = new NewscateDAL();
            MySqlDataReader sdr = dn.sqldatareader(mn);
            return sdr;
        }
        public int update(Model.Newscate mn)
        {
            NewscateDAL dn = new NewscateDAL();
            int result = dn.update(mn);
            return result;
        }
        public int _delete(Model.Newscate mn)
        {
            NewscateDAL dn = new NewscateDAL();
            int result = dn._delete(mn);
            return result;
        }
    }
}
