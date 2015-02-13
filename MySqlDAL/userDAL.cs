using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace MySqlDAL
{
    public class userDAL
    {
        //注册会员
        public int insert(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into user ( _username,_pwd,_email,_qq,_msn,_safequestion,_safepwd ) values(@username,@pwd,@email,@qq,@msn,@safeque,@safepwd)");
            MySqlParameter[] par ={
                                    new MySqlParameter("@username",MySqlDbType.VarChar,50),
                                    new MySqlParameter ("@pwd",MySqlDbType .VarChar,50),
                                    new MySqlParameter ("@email",MySqlDbType .VarChar,50),
                                    new MySqlParameter ("@qq",MySqlDbType .VarChar,50),
                                    new MySqlParameter ("@msn",MySqlDbType .VarChar,50),
                                    new MySqlParameter ("@safeque",MySqlDbType .VarChar,150),
                                    new MySqlParameter ("@safepwd",MySqlDbType .VarChar,150)
                                };
            par[0].Value = aa.username;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            par[2].Value = aa.email;
            par[3].Value = aa.qq;
            par[4].Value = aa.msn;
            par[5].Value = aa.safequestion;
            par[6].Value = aa.safepwd;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        //判断该用户邮箱是否存在
        public DataSet pan(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select _userid from user where _email=@email");
            MySqlParameter[] par ={
                                    new MySqlParameter("@email",MySqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            return DBHelperMySQL.Query(sql.ToString(), par);
        }
        public MySqlDataReader dd(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select _userid from user where _email=@email");
            MySqlParameter[] par ={
                                    new MySqlParameter("@email",MySqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }

        //读取会员信息
        public MySqlDataReader seleus(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from user where  _userid=@id");
            MySqlParameter[] par ={
                                    new MySqlParameter("@id",MySqlDbType.Int32)
                                };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
        //更新会员信息
        public int upuse(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update user set _username=@username,_pwd=@pwd,_email=@email,_qq=@qq,_msn=@msn,_safequestion=@safeque,_safepwd=@safepwd  where _userid=@id");
            MySqlParameter[] par ={
                                    new  MySqlParameter("@id",MySqlDbType.Int32),
                                    new  MySqlParameter("@username",MySqlDbType.VarChar,50),
                                    new  MySqlParameter("@pwd",MySqlDbType.VarChar,50),
                                    new  MySqlParameter("@email",MySqlDbType.VarChar,50),
                                    new  MySqlParameter("@qq",MySqlDbType.VarChar,50),
                                    new  MySqlParameter("@msn",MySqlDbType.VarChar,50),
                                    new  MySqlParameter("@safeque",MySqlDbType.VarChar ,150),
                                    new  MySqlParameter("@safepwd",MySqlDbType.VarChar ,150)
                                };
            par[0].Value = aa.userid;
            par[1].Value = aa.username;
            par[2].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            par[3].Value = aa.email;
            par[4].Value = aa.qq;
            par[5].Value = aa.msn;
            par[6].Value = aa.safequestion;
            par[7].Value = aa.safepwd;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        //会员登入
        public MySqlDataReader login(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select  _userid from user where _email=@email and _pwd=@pwd");
            MySqlParameter[] par ={
                                    new MySqlParameter("@email",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@pwd",MySqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            //
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
        //session
        public MySqlDataReader lo(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from user where _email=@email and _pwd=@pwd");
            MySqlParameter[] par ={
                                    new MySqlParameter("@email",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@pwd",MySqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
        //个人资料
        public MySqlDataReader drs(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from user where _userid=@userid");
            MySqlParameter[] par ={
                                    new MySqlParameter("@userid",MySqlDbType.VarChar,50)
                                };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
        //修改个人资料
        public int upd(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update user set _msn=@msn,_qq=@qq,_safequestion=@safe,_safepwd=@pwd where _userid=@id");
            MySqlParameter[] par ={
                                    new MySqlParameter("@msn",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@qq",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@safe",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@pwd",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@id",MySqlDbType.VarChar,50)   
                                };
            par[0].Value = aa.msn;
            par[1].Value = aa.qq;
            par[2].Value = aa.safequestion;
            par[3].Value = aa.safepwd;
            par[4].Value = aa.userid;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);

        }
        //判断该密码是否正确
        public MySqlDataReader drpw(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from user  where _pwd=@pwd and _userid=@id");
            MySqlParameter[] par ={
                                    new MySqlParameter("@pwd",MySqlDbType.VarChar,50),
                                    new MySqlParameter("@id",MySqlDbType.Int32)
                                };
            par[0].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            par[1].Value = aa.userid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
        //会员收藏夹
        public int seleid(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from collect where _userid=@id");
            MySqlParameter[] par ={
                                    new MySqlParameter("@id",MySqlDbType.Int32)
                                };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        //记住上次登入时间时间
        public int update(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update  user set _logintime=@time  where _userid=@id");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.Int32),
                                     new MySqlParameter("@time",MySqlDbType.DateTime,16)
                                 };
            par[0].Value = aa.userid;
            par[1].Value = aa.time;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public MySqlDataReader drti(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from user where _userid=@id");
            MySqlParameter[] par = {
                                     new  MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.userid;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }
        //更改密码
        public int upwd(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update user set _pwd=@apwd  where _userid=@id ");
            MySqlParameter[] par ={
                                    new MySqlParameter("@id",MySqlDbType.Int32),
                                    new MySqlParameter("@apwd",MySqlDbType.VarChar,50)
                                };
            par[0].Value = aa.userid;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public MySqlDataReader drid(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from user where _email=@email");
            MySqlParameter[] par = {
                                     new MySqlParameter("@email",MySqlDbType .VarChar,50)
                                 };
            par[0].Value = aa.email;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }


    }
    //地址
    public class address
    {
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
    }
    //订单
    public class order
    {
        //查看订单
        public DataSet dsor(int a, int b, Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable where _userid=@id  order by _ordertime ");
            MySqlParameter[] par ={
                                    new MySqlParameter("@id",MySqlDbType.Int32)
                                };
            par[0].Value = aa.userid;
            return DBHelperMySQL.PageQuery(sql.ToString(), a, b, par);
        }
        // 订单条数
        public int coun(Model.order aa)
        {
            String sql = "select count(*)from ordertable where _userid='" + aa.userid + "'";
            int i = Convert.ToInt32(Common.DB.ExecuteScalar(sql));
            return i;
        }
        //查看某条订单
        public DataSet kandi(Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable where _ordernum=@num");
            MySqlParameter[] par = {
                                     new MySqlParameter("@num",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = aa.ordernum;
            return DBHelperMySQL.Query(sql.ToString(), par);
        }
        public DataSet dsmai(Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable where _userid=@id and _paystate=1 order by _ordertime ");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.userid;
            return DBHelperMySQL.Query(sql.ToString(), par);
        }
        public int deo(Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ordertable where _userid=@uid and _id=@id");
            MySqlParameter[] par = {
                                     new  MySqlParameter("@uid",MySqlDbType.Int32),
                                     new  MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = aa.userid;
            par[1].Value = aa.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }

    }
}
