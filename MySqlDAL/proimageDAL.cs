using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlDAL
{
    public class proimageDAL
    {
        public int Insert(Model.proimage model)
        {

            StringBuilder sql = new StringBuilder();

            sql.Append(" insert into proimage ");

            sql.Append(" values (");

            sql.Append("@imageid,@imageurl,@color,@sizeid");

            sql.Append(")");

            MySqlParameter[] par = {
                              new MySqlParameter("@imageid",MySqlDbType.VarChar,50),
                              new MySqlParameter("@imageurl",MySqlDbType.VarChar,100),
                              new MySqlParameter("@color",MySqlDbType.VarChar,50),
                              new MySqlParameter("@sizeid",MySqlDbType.VarChar,50),                        
                             };


            par[0].Value = model.imageid;
            par[1].Value = model.imageurl;
            par[2].Value = model.color;
            par[3].Value = model.sizeid;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);

        }
        public int selectid(Model.proimage mym)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select _id  from proimage ");
            sql.Append(" where _sizeid=@sizeid ");

            MySqlParameter[] par = {
                              new MySqlParameter("@sizeid",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = mym.sizeid;

            return (int)DBHelperMySQL.GetSingle(sql.ToString(), par);


        }
        public DataSet select_sizeid(string mym)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select * from proimage ");
            sql.Append(" where _imageid=@imageid ");

            MySqlParameter[] par = {
                              new MySqlParameter("@imageid",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = mym;
            return DBHelperMySQL.Query(sql.ToString(), par);

        }
        public DataSet select_color(string mym)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" select * from proimage ");
            sql.Append(" where _sizeid=@sizeid ");

            MySqlParameter[] par = {
                              new MySqlParameter("@sizeid",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = mym;
            return DBHelperMySQL.Query(sql.ToString(), par);

        }

        public int delete(string mym)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" delete from proimage ");
            sql.Append(" where _imageid=@imageid ");

            MySqlParameter[] par = {
                              new MySqlParameter("@imageid",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = mym;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);



        }
        public int delect_1(string size_id)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" delete from proimage ");
            sql.Append(" where _sizeid=@sizeid");

            MySqlParameter[] par = {
                              new MySqlParameter("@sizeid",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = size_id;

            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);

        }
        public MySqlDataReader image_update(string size_id)
        {

            string sql = "select * from proimage where _sizeid='" + size_id + "'";
            return DBHelperMySQL.ExecuteReader(sql);

        }
        public int upimage(Model.proimage mym)
        {
            string sql = "update proimage set _imageurl='" + mym.imageurl + "' where _sizeid='" + mym.sizeid + "'";
            return DBHelperMySQL.ExecuteSql(sql);
        }
        public MySqlDataReader s_imageurl(string size_id)
        {

            string sql = "select * from proimage where _sizeid='" + size_id + "'";
            return DBHelperMySQL.ExecuteReader(sql);

        }


        //
        public MySqlDataReader dsim(Model.proimage aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select top 1 _imageurl from proimage where _imageid=@id");
            MySqlParameter[] par = {
                                     new MySqlParameter("@id",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = aa.id;
            return DBHelperMySQL.ExecuteReader(sql.ToString(), par);
        }


    }
}
