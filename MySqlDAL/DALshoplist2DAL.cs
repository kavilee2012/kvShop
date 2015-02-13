using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MySqlDAL
{
    public class DALshoplist2DAL
    {
        public MySqlDataReader readaddress(Model.address myaddress)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from address where _userid=@userid");
            MySqlParameter[] par ={new MySqlParameter ("@userid",MySqlDbType .Int32)
                                 };
            par[0].Value = myaddress.userid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);

        }
        public int insert(Model.order myorder)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into ordertable(_ordernum,_userid,_buyremarks,_count,_address,_tel,_mobile,_mail,_sumprice,_name,_needbill,_waysgive) ");
            sql.Append("values(@ordernum,@userid,@buyremarks,@count,@address,@tel,@mobile,@mail,@sumprice,@name,@needbill,@waysgive)");
            MySqlParameter[] par ={
                                new  MySqlParameter ("@ordernum",MySqlDbType .VarChar ,50),
                                new MySqlParameter ("@userid",MySqlDbType .Int32),
                                new MySqlParameter ("@buyremarks",MySqlDbType .VarChar ,350),
                                new MySqlParameter ("@count",MySqlDbType .Int32),
                                new MySqlParameter ("@address",MySqlDbType .VarChar ,150),
                                new MySqlParameter ("@tel",MySqlDbType .VarChar,50),
                                new MySqlParameter ("@mobile",MySqlDbType .VarChar ,50),
                                new MySqlParameter ("@mail",MySqlDbType .VarChar ,50),
                                new MySqlParameter ("@sumprice",MySqlDbType .Decimal), 
                                new MySqlParameter ("@name",MySqlDbType .VarChar ,50),
                                new MySqlParameter ("@needbill",MySqlDbType .Int32),
                                new MySqlParameter ("@waysgive",MySqlDbType .VarChar  ,50)
                                
                                };
            par[0].Value = myorder.ordernum;
            par[1].Value = myorder.userid;
            par[2].Value = myorder.buyremarks;
            par[3].Value = myorder.count;
            par[4].Value = myorder.address;
            par[5].Value = myorder.tel;
            par[6].Value = myorder.mobile;
            par[7].Value = myorder.mail;
            par[8].Value = myorder.sumprice;

            par[9].Value = myorder.name;
            par[10].Value = myorder.needbill;
            par[11].Value = myorder.waysgive;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public int insertdetail(Model.orderdetail myorderdetail)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into orderdetail(_count,_ordernum,_sumprice,_price,_weight,_sumweight,_title,_proid,_size,_color,_proimage,_cate) ");
            sql.Append("values(@count,@ordernum,@sumprice,@price,@weight,@sumweight,@title,@proid,@size,@color,@proimage,@cate)");
            MySqlParameter[] par ={
                                   new MySqlParameter ("@count",MySqlDbType .Int32),
                                   new MySqlParameter ("@ordernum",MySqlDbType .VarChar ,50),
                                   new  MySqlParameter ("@sumprice",MySqlDbType .Decimal),
                                   new MySqlParameter ("@price",MySqlDbType .Decimal),
                                   new MySqlParameter ("@weight",MySqlDbType .VarChar ,50),
                                   new MySqlParameter ("@sumweight",MySqlDbType .VarChar ,50),
                                   new MySqlParameter ("@title",MySqlDbType .VarChar ,50),
                                   new MySqlParameter ("@proid",MySqlDbType .Int32),
                                   new MySqlParameter ("@size",MySqlDbType .VarChar ,50),
                                   new MySqlParameter ("@color",MySqlDbType .VarChar ,50),
                               new MySqlParameter ("@proimage",MySqlDbType .VarChar ,50),
                               new MySqlParameter ("@cate",MySqlDbType .VarChar ,50)
                               };

            par[0].Value = myorderdetail.count;
            par[1].Value = myorderdetail.ordernum;
            par[2].Value = myorderdetail.sumprice;
            par[3].Value = myorderdetail.price;
            par[4].Value = myorderdetail.weight;
            par[5].Value = myorderdetail.sumweight;
            par[6].Value = myorderdetail.title;
            par[7].Value = myorderdetail.proid;
            par[8].Value = myorderdetail.size;
            par[9].Value = myorderdetail.color;
            par[10].Value = myorderdetail.proimage;
            par[11].Value = myorderdetail.cate;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }


        public MySqlDataReader readpro(Model.product myorder)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from product where _id=@id");
            MySqlParameter[] par = { new MySqlParameter("@id", MySqlDbType.Int32) };
            par[0].Value = myorder.id;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);


        }
    }
}
