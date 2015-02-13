using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MySqlDAL
{
    public class dalaaddressDAL
    {
        //填写送货地址
        public int addre(Model.address aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into address (_tel,_mobile, _address ,_name, _mail) values(@tel,@mobile,@address,@name,@mail)");
            MySqlParameter[] par ={
                                   
                                    new MySqlParameter("@tel",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@mobile",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@address",MySqlDbType.VarChar,150),
                                    new MySqlParameter("@name",MySqlDbType.VarChar,150),
                                    new MySqlParameter("@mail",MySqlDbType.VarChar,50)
                                };

            par[0].Value = aa.tel;
            par[0].Value = aa.mobile;
            par[0].Value = aa.Address;
            par[0].Value = aa.name;
            par[0].Value = aa.mail;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        //查看送货地址
        public MySqlDataReader drad(Model.address aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" select * from address where _userid=@id ");
            MySqlParameter[] par ={
                                    new MySqlParameter("@id",MySqlDbType.Int32)
                                };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }

        //更新地址
        public int upad(Model.address aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update address set _mail=@mail,_name=@name,_mobile=@mobile,_tel=@tel,_address=@addr where _userid=@id");
            MySqlParameter[] par ={
                                    new   MySqlParameter("@mail",MySqlDbType.VarChar,50),
                                    new   MySqlParameter("@name",MySqlDbType.VarChar,50),
                                    new   MySqlParameter("@mobile",MySqlDbType.VarChar,50),
                                    new   MySqlParameter("@tel",MySqlDbType.VarChar,50),
                                    new   MySqlParameter("@addr",MySqlDbType.VarChar,50),
                                    new   MySqlParameter("@id",MySqlDbType.Int32)
                                    
                                };
            par[0].Value = aa.mail;
            par[1].Value = aa.name;
            par[2].Value = aa.mobile;
            par[3].Value = aa.tel;
            par[4].Value = aa.Address;
            par[5].Value = aa.userid;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        //插入用户号于地址表
        public int insert(Model.address aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into address (_userid) values(@id)");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public MySqlDataReader adr(Model.address aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from address where _userid =@id");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
    }
}
