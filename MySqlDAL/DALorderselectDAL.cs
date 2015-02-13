using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace MySqlDAL
{
    public class DALorderselectDAL
    {
        /*****************订单***************/
        public int pageint()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from ordertable");
            int result = Convert.ToInt32(DBHelperMySQL.ExecuteScalar(sql.ToString()));
            return result;
        }
        public int pageint1(Model.order myorder)
        {
            StringBuilder sql = new StringBuilder();
            // //sql.Append("select count(*) from ordertable where _ordernum like '%3%'");

            //// int result =Convert.ToInt32 ( DBHelperMySQL.ExecuteScalar(sql.ToString()));
            //// int result=Convert .ToInt32 (Common .DbHelperSQL .)
            // //int result = DBHelperMySQL.Query(sql.ToString()).Tables[0].Rows.Count;
            sql.Append("select count(*) from ordertable where _ordernum like '%" + myorder.ordernum + "%'");
            int result = Convert.ToInt32(DBHelperMySQL.ExecuteScalar(sql.ToString()));

            //sql.Append("select * from ordertable where _ordernum like '@ordernum%'");
            // MySqlParameter[] par = { new MySqlParameter("@ordernum", MySqlDbType.VarChar, 50) };

            // par[0].Value = myorder.ordernum;

            //DataSet ds = DBHelperMySQL.Query(sql.ToString(),par);

            //int result = ds.Tables[0].Rows.Count;



            return result;
        }
        public DataSet pagebind(int a, int b)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable order by _id desc ");
            DataSet ds = DBHelperMySQL.pageQuery(sql.ToString(), a, b);
            return ds;
        }
        public DataSet pagebind1(int a, int b, Model.order myorder)
        {
            StringBuilder sql = new StringBuilder();
            //   sql.Append("select * from ordertable where _ordernum like '%@ordernum%' order by _id desc");
            sql.Append("select * from ordertable where _ordernum like '%" + myorder.ordernum + "%' order by _id desc");
            // MySqlParameter[] par = { new MySqlParameter("@ordernum", MySqlDbType.VarChar, 50) };
            //par[0].Value = myorder.ordernum;
            // return DBHelperMySQL.PageQuery  (sql.ToString (),a,b, par);
            return DBHelperMySQL.PagedataSet(sql.ToString(), a, b, "info");
        }
        public int delete(Model.order myorder)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ordertable where _id=@id");
            MySqlParameter[] par = { new MySqlParameter("@id", MySqlDbType.Int32) };
            par[0].Value = myorder.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }

    }
}
