using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MySqlDAL
{
    public class downlistDAL
    {
        public int downloadadd(Model.downlist md)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" insert into downlist   ");
            sql.Append(" (_title,_size,_click,_uploadurl)");
            sql.Append(" values (@name,@size,@click,@url)");
            MySqlParameter[] par = { new MySqlParameter("@name",MySqlDbType.VarChar,150 ),
                                new MySqlParameter("@size",MySqlDbType.VarChar,50),
                                new MySqlParameter("@click",MySqlDbType.Int32),
                                new MySqlParameter("@url",MySqlDbType.VarChar,200)
                              };
            par[0].Value = md.title;
            par[1].Value = md.size;
            par[2].Value = md.click;
            par[3].Value = md.uploadurl;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public int update(Model.downlist md)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" update downlist set ");
            sql.Append(" _title=@name,_size=@size,_click=@click,_uploadurl=@url  ");
            sql.Append(" where _id=@id  ");
            MySqlParameter[] par ={ new MySqlParameter("@name",MySqlDbType.VarChar,150 ),
                                new MySqlParameter("@size",MySqlDbType.VarChar,50),
                                new MySqlParameter("@click",MySqlDbType.Int32),
                                new MySqlParameter("@url",MySqlDbType.VarChar,200),
                                new MySqlParameter("@id",MySqlDbType.Int32)
                               };
            par[0].Value = md.title;
            par[1].Value = md.size;
            par[2].Value = md.click;
            par[3].Value = md.uploadurl;
            par[4].Value = md.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public MySqlDataReader datareader(Model.downlist md)
        {
            string str = "select * from downlist where _id=" + md.id + "  ";
            MySqlDataReader sdr = DBHelperMySQL.ExecuteReader(str);
            return sdr;
        }
        public int _delete(Model.downlist md)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" delete from downlist ");
            sql.Append(" where _id=@id ");
            MySqlParameter[] par ={ new MySqlParameter ("@id",MySqlDbType.Int32) 
                               };
            par[0].Value = md.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
        public int click(Model.downlist md)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" update downlist set ");
            sql.Append(" _click=@click  ");
            sql.Append(" where _id=@id  ");
            MySqlParameter[] par ={ 
                                new MySqlParameter("@click",MySqlDbType.Int32),
                                new MySqlParameter("@id",MySqlDbType.Int32)
                               };
            par[0].Value = md.click;
            par[1].Value = md.id;
            return DBHelperMySQL.ExecuteSql(sql.ToString(), par);
        }
    }
}
