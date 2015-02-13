using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlDAL
{
    public class sizeDAL
    {
        public int Insert(Model.size model)
        {

            StringBuilder sql = new StringBuilder();

            sql.Append("insert into size ");

            sql.Append(" values (");

            sql.Append("@sizid,@sizename");

            sql.Append(")");

            MySqlParameter[] par = {
                              new MySqlParameter("@sizid",MySqlDbType.VarChar,50),
                              new MySqlParameter("@sizename",MySqlDbType.VarChar,50)
                                                    
                             };

            par[0].Value = model.sizeid;
            par[1].Value = model.sizename;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);

        }
        public int delete(string size_id)
        {

            StringBuilder sql = new StringBuilder();

            sql.Append("delete from [size] ");
            sql.Append("where _sizeid=@sizeid");
            MySqlParameter[] par = {
                              new MySqlParameter("@sizeid",MySqlDbType.VarChar,50)
                                };

            par[0].Value = size_id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);

        }
        public DataSet select_size(string size_id)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select * from [size] ");
            sql.Append("where _sizeid=@sizeid");

            MySqlParameter[] par = {
                              new MySqlParameter("@sizeid",MySqlDbType.VarChar,50)
                                };

            par[0].Value = size_id;
            return DBHelperMySQL.Query(sql.ToString(), par);

        }
        public int delete_1(int u_id)
        {
            string sql = "delete from size where _id=" + u_id + "";
            return DBHelperMySQL.ExecuteSql(sql);
        }
    }
}
