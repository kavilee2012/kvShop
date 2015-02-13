using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MySqlDAL
{
    public class NewsDAL
    {
        public int add(Model.News mn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" insert into news ");
            sql.Append(" (_title,_from,_author,_top,_click,_content,_cateid,_ispic) ");
            sql.Append(" values( @title,@from,@author,@top,@click,@content,@cateid,@ispic ) ");
            MySqlParameter[] par = { new MySqlParameter( "@title",MySqlDbType.VarChar,50 ),
                                   new MySqlParameter("@from",MySqlDbType.VarChar,50),
                                   new MySqlParameter("@author",MySqlDbType.VarChar,50),
                                   new MySqlParameter("@top",MySqlDbType.VarChar,50),
                                   new MySqlParameter("@click",MySqlDbType.VarChar,50),
                                   new MySqlParameter("@content",MySqlDbType.VarChar,0),
                                   new MySqlParameter("@cateid",MySqlDbType.VarChar,50),
                                   new MySqlParameter("@ispic",MySqlDbType.VarChar,50)
                                 };
            par[0].Value = mn.Title;
            par[1].Value = mn.From;
            par[2].Value = mn.Author;
            par[3].Value = mn.Top;
            par[4].Value = mn.Click;
            par[5].Value = mn.Content;
            par[6].Value = mn.Cateid;
            par[7].Value = mn.Ispic;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
        public int _delete(Model.News mn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" delete from news where _id=@nid ");
            MySqlParameter[] par = { new MySqlParameter("@nid", MySqlDbType.Int32) };
            par[0].Value = mn.ID;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
        public MySqlDataReader datareader(Model.News mn)
        {
            string str = " select * from news where _id=" + mn.ID + " ";
            MySqlDataReader dr = DBHelperMySQL.ExecuteReader(str);
            return dr;
        }
        public int update(Model.News mn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" update news set ");
            sql.Append(" _title=@name, _from=@source, _author=@author,_top=@hot,_click=@count,_content=@info,_cateid=@nid,_ispic=@pic ");
            sql.Append(" where _id=@id ");
            MySqlParameter[] par ={
                                 
                                  new MySqlParameter( "@name",MySqlDbType.VarChar,50)  ,
                                  new MySqlParameter("@source",MySqlDbType.VarChar,50),
                                  new MySqlParameter("@author",MySqlDbType.VarChar,50),
                                  new MySqlParameter("@hot",MySqlDbType.Int32),
                                  new MySqlParameter("@count",MySqlDbType.Int32),
                                  new MySqlParameter("@info",MySqlDbType.VarChar,0),
                                  new MySqlParameter("@nid",MySqlDbType.Int32),
                                  new MySqlParameter("@pic",MySqlDbType.Int32 ),
                                  new MySqlParameter("@id", MySqlDbType.Int32)
                                };

            par[0].Value = mn.Title;
            par[1].Value = mn.From;
            par[2].Value = mn.Author;
            par[3].Value = mn.Top;
            par[4].Value = mn.Click;
            par[5].Value = mn.Content;
            par[6].Value = mn.Cateid;
            par[7].Value = mn.Ispic;
            par[8].Value = mn.ID;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
    }
}
