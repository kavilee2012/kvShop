using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlDAL
{
    public class procateDAL
    {
        public int Insert(Model.procate model)
        {

            StringBuilder sql = new StringBuilder();

            sql.Append("insert into procate ");

            sql.Append(" values (");

            sql.Append("@catename,@fathercateid");

            sql.Append(")");

            MySqlParameter[] par = {
                              new MySqlParameter("@catename",MySqlDbType.VarChar,50),
                              new MySqlParameter("@fathercateid",MySqlDbType.Int32),
                             
                             
                             };


            par[0].Value = model.catename;
            par[1].Value = model.fathercateid;






            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);

        }
        public DataSet dataset()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select * from procate");

            return DBHelperMySQL.Query(sql.ToString());

        }
        public DataSet data_set()
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select * from procate,fathercate where procate._fathercateid=fathercate._fathercateid");

            return DBHelperMySQL.Query(sql.ToString());

        }
        public string select_name(int cate_id)
        {
            string sql = "select _catename from procate where _cateid=" + cate_id + "";
            return Convert.ToString(DBHelperMySQL.ExecuteScalar(sql));

        }
        public int num(int f_id)
        {
            string sql = "select count(*) from procate where _fathercateid=" + f_id + "";
            return Convert.ToInt32(DBHelperMySQL.ExecuteScalar(sql));
        }
        public int update(Model.procate mym)
        {
            string sql = "update procate set _catename='" + mym.catename + "', _fathercateid=" + mym.fathercateid + " where _cateid=" + mym.cateid + "";
            return Convert.ToInt32(DBHelperMySQL.ExecuteSql(sql));
        }
        public int delete(int cate_id)
        {
            string sql = "delete from procate where _cateid=" + cate_id + "";
            return Convert.ToInt32(DBHelperMySQL.ExecuteSql(sql));
        }
        public DataSet data_f(int f_cateid)
        {
            string sql = "select *  from procate where _fathercateid=" + f_cateid + "";
            return DBHelperMySQL.Query(sql);
        }
    }
}
