using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MySqlDAL
{
    public class NewscateDAL
    {
        public int insert(Model.Newscate mn)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("insert into newscate");
            sql.Append(" values (");
            sql.Append(" @username ");
            sql.Append(")");
            MySqlParameter[] par = {
                                 new MySqlParameter("@username",MySqlDbType.VarChar,50)
                             };
            par[0].Value = mn.Catename;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
        public MySqlDataReader sqldatareader(Model.Newscate mn)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("select * from newscate");
            sql.Append(" where _cateid = @id");
            MySqlParameter[] par = { new MySqlParameter("@id", MySqlDbType.Int32) };
            par[0].Value = mn.ID;
            MySqlDataReader sdr = DBHelperMySQL.ExecuteReader(sql.ToString(), par);
            return sdr;
        }
        public int update(Model.Newscate mn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" update newscate set ");
            sql.Append(" _catename=@name ");
            sql.Append(" where _cateid = @id ");
            MySqlParameter[] par = { new MySqlParameter("@name",MySqlDbType.VarChar,50),
                                  new MySqlParameter("@id",MySqlDbType.Int32) };
            par[0].Value = mn.Catename;
            par[1].Value = mn.ID;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
        public int _delete(Model.Newscate mn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" delete from newscate ");
            sql.Append(" where _cateid=@id ");
            MySqlParameter[] par = { new MySqlParameter("@id", MySqlDbType.Int32) };
            par[0].Value = mn.ID;
            int result = DBHelperMySQL.ExecuteSql(sql.ToString(), par);
            return result;
        }
    }
}
