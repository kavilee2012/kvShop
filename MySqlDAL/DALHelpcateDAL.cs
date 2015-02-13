using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlDAL
{
    public class DALHelpcateDAL
    {
        public int insert(Model.Helpcate mh)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into helpcate");
            sql.Append(" values ( ");
            sql.Append("@name");
            sql.Append(")");
            MySqlParameter[] par = {
                                     new MySqlParameter("@name",MySqlDbType.VarChar,50) 
                                 };
            par[0].Value = mh.Catename;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public MySqlDataReader mySqlDataReader(Model.Helpcate mh)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select * from helpcate");
            sql.Append(" where _cateid = @id");
            MySqlParameter[] par = { new MySqlParameter("@id", MySqlDbType.Int32) };
            par[0].Value = mh.ID;
            MySqlDataReader sdr = DBHelperMySQL.ExecuteReader(sql.ToString(), par);
            return sdr;
        }
        public int _delete(Model.Helpcate mh)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" delete from helpcate  ");
            sql.Append(" where _cateid=@id  ");
            MySqlParameter[] par = { new MySqlParameter("@id", MySqlDbType.Int32) };
            par[0].Value = mh.ID;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
        public int update(Model.Helpcate mh)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" update helpcate set ");
            sql.Append(" _catename=@name ");
            sql.Append(" where _cateid=@id ");
            MySqlParameter[] par = { new MySqlParameter("@name",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@id",MySqlDbType.Int32) };
            par[0].Value = mh.Catename;
            par[1].Value = mh.ID;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }

        public DataSet select()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from helpcate");

            return DBHelperMySQL.Query(sql.ToString());
        }

        public DataSet select(int cateid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from helpcate where _cateid=" + cateid + "");
            return DBHelperMySQL.Query(sql.ToString());

        }
    }
}
