using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlDAL
{
    public class collectDAL
    {
        public DataSet drco(int a, int b, Model.collect aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from collect  where _userid=@id");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.userid;
            return DBHelperMySQL.PageQuery(sql.ToString(), a, b, par);
        }
        public int count(Model.collect aa)
        {
            String sql = "select count(*) from collect where _userid='" + aa.userid + "'";
            int i = Convert.ToInt32(DBHelperMySQL.ExecuteScalar(sql));
            return i;
        }

        public int inser(Model.collect aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into collect (_userid)values(@id)");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType .Int32)
                                 };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public int inserc(Model.collect aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into collect (_userid,_proid,_proname,_proprice,_proimage)values(@userid,@id,@name,@price,@image)");
            MySqlParameter[] par = {
                                     new MySqlParameter("@userid",MySqlDbType.Int32),
                                     new MySqlParameter("@id",MySqlDbType.Int32),
                                     new MySqlParameter("@name",MySqlDbType.VarChar,50),
                                     new MySqlParameter("@price",MySqlDbType.Decimal),
                                     new MySqlParameter("@image",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = aa.userid;
            par[1].Value = aa.proid;
            par[2].Value = aa.proname;
            par[3].Value = aa.proprice;
            par[4].Value = aa.proimage;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public int deco(Model.collect aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from collect where _id=@id");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public MySqlDataReader drcopr(Model.collect aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from collect where _proid=@id");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.proid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
        
    }
}
