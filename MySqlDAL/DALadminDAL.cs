using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Model;

namespace MySqlDAL
{
    public class DALadminDAL
    {
        public MySqlDataReader checkAdmin(admin admim)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from admin where _name=@name");

            MySqlParameter[] par = {
                              new MySqlParameter("@name",MySqlDbType.VarChar,50)                  
                             
                             };
            par[0].Value = admim.name;


            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }

        public int insertAdmin(admin admin)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into admin values(@name,@pwd,@role)");




            MySqlParameter[] par ={
                               new MySqlParameter("@name",MySqlDbType.VarChar,50),
                               new MySqlParameter ("@pwd",MySqlDbType.VarChar,50),
                               new MySqlParameter ("@role",MySqlDbType.Int32)
                               };
            par[0].Value = admin.name;
            par[1].Value = admin.pwd;
            par[2].Value = admin.role;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);

        }

        public int deleteAdmin(admin admin)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from admin where _id=@id");

            MySqlParameter[] par = { 
                                 new MySqlParameter("@id",MySqlDbType.Int32)
                                 
                                 };

            par[0].Value = admin.id;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }

        public DataSet selectAdmin()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from admin where _role=" + 0 + "");

            return DBHelperMySQL.Query(sql.ToString());
        }

        public int updateAdmin(admin admin)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update admin set _name=@name,_pwd=@pwd where _id=@id");

            MySqlParameter[] par = {
                                 new MySqlParameter("@name",MySqlDbType.VarChar,50),
                                 new MySqlParameter("@pwd",MySqlDbType.VarChar,50),
                                 new MySqlParameter("@id",MySqlDbType.Int32)
                                 };
            par[0].Value = admin.name;
            par[1].Value = admin.pwd;
            par[2].Value = admin.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }

        public MySqlDataReader readAdmin(admin admin)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from admin ");
            sql.Append("where _id=@id");

            MySqlParameter[] par = {
                                 new MySqlParameter("@id",MySqlDbType.Int32)
                                 
                                 };

            par[0].Value = admin.id;

            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);

        }

        public MySqlDataReader _login(admin admin)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select * from admin where _name=@name and _pwd=@pwd and _role=@role");

            MySqlParameter[] pra = { 
                                 new MySqlParameter("@name",MySqlDbType.VarChar,50),
                                 new MySqlParameter("@pwd",MySqlDbType.VarChar,50),
                                 new MySqlParameter("@role",MySqlDbType.Int32)
                                 };
            pra[0].Value = admin.name;
            pra[1].Value = Common.DESEncrypt.Encrypt(admin.pwd);
            pra[2].Value = admin.role;

            return DBHelperMySQL.ExecuteReader(sql.ToString(), pra);
        }




        public DataSet adminlist(int pageindex, int pagesize, string table)
        {
            string sqlstr = "select * from admin where _role=" + 0 + "";

            DataSet ds = DBHelperMySQL.PagedataSet(sqlstr, pageindex, pagesize, table);
            return ds;
        }

        public int admin()
        {
            string sqlstr = "select count(*) from admin where _role=" + 0 + "";
            int result;
            if (DBHelperMySQL.ExecuteScalar(sqlstr) == null)
            {
                result = 0;

            }
            else
            {
                result = (int)DBHelperMySQL.ExecuteScalar(sqlstr);
            }
            return result;

        }

        public int s_admin(string name)
        {
            string sqlstr = "select count(*) from admin where _name like '%" + name + "%' and _role=" + 0 + "";
            int result;
            if (DBHelperMySQL.ExecuteScalar(sqlstr) == null)
            {
                result = 0;

            }
            else
            {
                result = (int)DBHelperMySQL.ExecuteScalar(sqlstr);
            }
            return result;
        }

        public DataSet S_admin(int pageindex, int pagesize, string table, string name)
        {

            string sqlstr = "select * from admin where _name like '%" + name + "%' and _role=" + 0 + "";

            DataSet ds = DBHelperMySQL.PagedataSet(sqlstr, pageindex, pagesize, table);
            return ds;

        }

        public int hh(Model.admin ad)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("insert into admin(_name,_pwd) values(@name,@pwd)");
            MySqlParameter[] par ={new MySqlParameter ("@name",MySqlDbType .VarChar, 50),
                           new MySqlParameter ("@pwd",MySqlDbType .VarChar, 50)};
            par[0].Value = ad.name;
            par[1].Value = ad.pwd;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
    }
}
