using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlDAL
{
    public class DALorderupdateDAL
    {
        public MySqlDataReader readorder(Model.order myorder)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable where _id=@id");
            MySqlParameter[] par = { new MySqlParameter("@id", MySqlDbType.Int32) };
            par[0].Value = myorder.id;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);


        }
        public int update(Model.order myorder)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update ordertable set _paystate=@paystate,_prostate=@prostate,_sellremarks=@sellremarks where _id=@id");
            MySqlParameter[] par ={new  MySqlParameter ("@id",MySqlDbType .Int32),
                                new  MySqlParameter ("@paystate",MySqlDbType .Int32),
                                new  MySqlParameter ("@prostate",MySqlDbType .Int32),
                                new MySqlParameter ("@sellremarks", MySqlDbType .VarChar ,350)
                                };
            par[0].Value = myorder.id;
            par[1].Value = myorder.paystate;
            par[2].Value = myorder.prostate;
            par[3].Value = myorder.sellremarks;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public DataSet bindgr(Model.orderdetail myorderdetail)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from orderdetail where _ordernum=@ordernum");
            MySqlParameter[] par ={new MySqlParameter ("@ordernum",MySqlDbType.VarChar ,50)
                                };
            par[0].Value = myorderdetail.ordernum;
            return DBHelperMySQL.Query(sql.ToString(), par);

        }
    }
}
