using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlDAL
{
    public class fathercateDAL
    {
        public int insert(Model.fathercate mym)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("insert into fathercate ");

            sql.Append(" values (");

            sql.Append("@fathername");

            sql.Append(")");

            MySqlParameter[] par = {
                             
                              new MySqlParameter("@fathername",MySqlDbType.VarChar,50),
                             
                             };



            par[0].Value = mym.fathername;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public DataSet dataset()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select * from fathercate");

            return DBHelperMySQL.Query(sql.ToString());
        }
        public int update(Model.fathercate mym)
        {
            string sql = "update fathercate set _fathername='" + mym.fathername + "' where _fathercateid=" + mym.fathercateid + "";
            return DBHelperMySQL.ExecuteSql(sql);


        }
        public int delete(int f_id)
        {
            string sql = "delete from fathercate where _fathercateid=" + f_id + " ";
            return DBHelperMySQL.ExecuteSql(sql);
        }

    }
}
